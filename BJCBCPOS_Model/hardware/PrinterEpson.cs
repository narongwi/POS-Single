﻿using System;
using System.Collections;
using System.Data;
using BCOPOSEPSON;
using BJCBCPRNFFTI.FFTIPrinting;

namespace BJCBCPOS_Model
{
    public class PrinterEpson: IHardware
    {
        private clsOPOSEPSON opos = null;
        private clsOPOSEPSON.DrawerStatusEventHandler drawerCurrentEvent = null;
        private const string SeqCol = "Seq";
        private const string MsgTextCol = "Msg_text";
        private const string MsgAmtCol = "Msg_amt";
        private const string MsgPosCol = "Msg_text_Position";
        private static bool drawerChecked = false;
        private static bool printerChecked = false;
        private static bool drawerOpen;
        private Printing fftiPrint = null;

        public bool isDrawerOpened
        {
            get
            {
                try
                {
                    AppLog.writeDrawerEvent("Drawer Status from OPOS = " + opos.DrawerOpened);
                    return opos.DrawerOpened;
                }
                catch
                {
                    return false;
                }
            }
        }

        public PrinterEpson(string key)
        {
            try
            {
                AppLog.writeLog("Initial Hardware with BCOPOSEPSON.dll");
                if (opos == null)
                {
                    opos = new clsOPOSEPSON(key);
                    drawerChecked = false;
                    printerChecked = false;
                }

                if (fftiPrint == null)
                {
                    fftiPrint = new Printing();
                }
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
            }
        }

        public bool checkCashDrawer()
        {
            try
            {
                if (!drawerChecked)
                {
                    string res = opos.OpenCD();
                    if (res.StartsWith("error"))
                    {
                        throw new Exception(res);
                    }
                    opos.DrawerStatus += new clsOPOSEPSON.DrawerStatusEventHandler(drawerListenersStatus);
                    drawerChecked = true;
                }
                return drawerChecked;
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
                return false;
            }
        }

        void dra(string status)
        {
            throw new NotImplementedException();
        }

        public bool openDrawer()
        {
            try
            {
                AppLog.writeDrawerEvent("call KickDrawer");
                return opos.KickDrawer();
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
                return false;
            }
        }

        public void addDrawerListeners(Hardware.DrawerListener listener)
        {
            try
            {
                // clear current event listener
                if (drawerCurrentEvent != null)
                {
                    opos.DrawerStatus -= drawerCurrentEvent;
                }

                // add new event
                drawerCurrentEvent = new clsOPOSEPSON.DrawerStatusEventHandler(listener);
                opos.DrawerStatus += drawerCurrentEvent;
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
            }
        }

        public void clearDrawerListeners()
        {
            try
            {
                // clear current event listener
                if (drawerCurrentEvent != null)
                {
                    opos.DrawerStatus -= drawerCurrentEvent;
                }
                drawerCurrentEvent = null;
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
            }
        }

        public bool checkPrinter()
        {
            try
            {
                if (!printerChecked)
                {
                    string res = opos.OpenPrinter();

                    if (res.StartsWith("error"))
                    {
                        throw new Exception(res);
                    }
                    printerChecked = true;
                }
                else
                {
                    try
                    {
                        opos.ClosePrinter();
                    }
                    catch (Exception e)
                    {
                        AppLog.writeLog(e);
                    }

                    printerChecked = false;
                    string res = opos.OpenPrinter();

                    if (res.StartsWith("error"))
                    {
                        throw new Exception(res);
                    }
                    printerChecked = true;
                }
                return printerChecked;
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
                return false;
            }
        }

        public bool printTermal(ArrayList data)
        {
            try
            {
                string res = opos.PrintAsText(data);
                if (res.StartsWith("error"))
                {
                    throw new Exception(res);
                }
                return true;
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
                return false;
            }
        }

        public bool printTermal(DataTable data)
        {
            try
            {
                if (data != null && data.Rows.Count > 0)
                {
                    if (data.Columns.Contains(MsgTextCol) && data.Columns.Contains(MsgAmtCol))
                    {
                        DataView view = data.DefaultView;
                        // sort by seq
                        if (data.Columns.Contains(SeqCol))
                        {
                            view.Sort = SeqCol + " ASC";
                        }

                        string MsgAmt, MsgText;
                        ArrayList print = new ArrayList();
                        if (data.Columns.Contains(MsgPosCol))
                        {
                            string posText = "";
                            foreach (DataRowView row in view)
                            {
                                MsgAmt = row[MsgAmtCol] == null ? "" : row[MsgAmtCol].ToString();
                                MsgText = row[MsgTextCol] == null ? "" : row[MsgTextCol].ToString();
                                if (!string.IsNullOrEmpty(MsgAmt) && !string.IsNullOrWhiteSpace(MsgAmt))
                                {
                                    if (MsgText.StartsWith("&P") || MsgText.StartsWith("&B"))
                                    {
                                        print.Add(MsgText);
                                    }
                                    else
                                    {
                                        print.Add(MsgText + "|" + MsgAmt);
                                    }
                                }
                                else
                                {
                                    posText = row[MsgPosCol].ToString();
                                    if (posText.Trim().ToUpper() == "C")
                                    {
                                        posText = "<C>";
                                    }
                                    else if (posText.Trim().ToUpper() == "R")
                                    {
                                        posText = "<R>";
                                    }
                                    else
                                    {
                                        posText = "";
                                    }
                                    print.Add(posText + MsgText);
                                }
                            }
                        }
                        else
                        {
                            foreach (DataRowView row in view)
                            {
                                MsgAmt = row[MsgAmtCol] == null ? "" : row[MsgAmtCol].ToString();
                                MsgText = row[MsgTextCol] == null ? "" : row[MsgTextCol].ToString();
                                if (!string.IsNullOrEmpty(MsgAmt) && !string.IsNullOrWhiteSpace(MsgAmt))
                                {
                                    if (MsgText.StartsWith("&P") || MsgText.StartsWith("&B"))
                                    {
                                        print.Add(MsgText);
                                    }
                                    else
                                    {
                                        print.Add(MsgText + "|" + MsgAmt);
                                    }
                                }
                                else
                                {
                                    print.Add(MsgText);
                                }
                            }
                        }

                        string res = opos.PrintAsText(print);
                        if (res.StartsWith("error"))
                        {
                            throw new Exception(res);
                        }
                        return true;
                    }
                    else
                    {
                        throw new Exception("DataTable does not contains required column name.");
                    }
                }
                else
                {
                    AppLog.writeLog(new Exception("No Data To Print."));
                    return true;
                }
            }
            catch (Exception ex)
            {
                AppLog.writeLog(ex);
                return false;
            }
        }

        public bool printFullTax(string refNo, string fftiNo, string offtiNo)
        {
            //fftiPrint.StartPreview(saleRef);
            return true;
        }

        private void drawerListenersStatus(string status)
        {
            AppLog.writeDrawerEvent("listeners status change return = " + status);
            drawerOpen = Convert.ToBoolean(status);
        }


        public bool printCN(string refCN)
        {
            throw new NotImplementedException();
        }
    }
}