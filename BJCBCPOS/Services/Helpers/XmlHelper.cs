using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace BJCBCPOS.Services.Helpers {
    public static class XmlHelper {
        /// <summary>
        /// Deserialize XML File the object T
        /// </summary>
        /// <param name="xmlFile">Full Path and file name</param>
        /// <returns>Object T</returns>
        public static T DeserializeFromFile<T>(this T toDeserialize,string xmlFile) {
            XmlSerializer res = new XmlSerializer(toDeserialize.GetType());
            using(StreamReader file = new StreamReader(xmlFile)) {
                return (T)res.Deserialize(file);
            }
        }

        /// <summary>
        ///  Deserialize XML Content String to the object T
        /// </summary>
        /// <param name="xmlString">xml content</param>
        /// <returns>Object T</returns>
        public static T DeserializeFromString<T>(this string xmlString, T toDeserialize) {
            XmlSerializer res = new XmlSerializer(toDeserialize.GetType());
            using(TextReader reader = new StringReader(xmlString)) {
                return (T)res.Deserialize(reader);
            }
        }

        /// <summary>
        /// Serialize Object to xml content without namespaces
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="toSerialize"></param>
        /// <returns>Xml String</returns>
        public static string SerializeObject<T>(this T toSerialize) {
            XmlWriterSettings settings = new XmlWriterSettings {/*Indent = true,*/ OmitXmlDeclaration = true };
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            using(var stream = new StringWriter())
            using(var writer = XmlWriter.Create(stream,settings)) {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer,toSerialize,namespaces);
                return stream.ToString();
            }
        }
    }

    // How to Use
    //public class BillPaymentService {
    //    private readonly string basePath = @"D:\Repository\Deftsoft\POS-Single\BJCBCPOS_Solution\BJCBCPOS\OtherServices\BillPayment";
    //    public BillPayment.ServiceType.ServiceTypeResp GetServiceType() {
    //        try {
    //            // request
    //            var request = new BillPayment.ServiceType.ServiceTypeReq();
    //            request = request.DeserializeFromFile(Path.Combine(basePath,"1. Bill Payment List Menu Request.xml"));
    //            var xlmparam = request.SerializeObject();

    //            // response
    //            var serviceType = new BillPayment.ServiceType.ServiceTypeResp();
    //            return serviceType.DeserializeFromFile(Path.Combine(basePath,"2. Bill Payment List Menu Response.xml"));

    //        } catch(Exception ex) {

    //            throw ex;
    //        }
    //    }
    //}
}
