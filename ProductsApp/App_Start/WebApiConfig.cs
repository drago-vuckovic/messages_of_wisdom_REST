using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Xml.Serialization;
using Mudrolije.Models;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Mudrolije
{
    public static class WebApiConfig
    {

        public class PrilagodjavanjeXmlAtributaXmlMediaTypeFormatter : XmlMediaTypeFormatter
        {
            public override Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content,
                                                    TransportContext transportContext)
            {
                try
                {
                    var xmlSerializerNamespaces = new XmlSerializerNamespaces();
                    foreach (var atribut in type.GetCustomAttributes(true))
                    {
                        var atributKorjenskogXmlElementa = atribut as XmlRootAttribute;
                        if (atributKorjenskogXmlElementa != null)
                        {
                            xmlSerializerNamespaces.Add(string.Empty, atributKorjenskogXmlElementa.Namespace);
                        }
                    }

                    if (xmlSerializerNamespaces.Count == 0)
                    {
                        xmlSerializerNamespaces.Add(string.Empty, string.Empty);
                    }

                    var task = Task.Factory.StartNew(() =>
                    {
                        var xmlSerializer = new XmlSerializer(type);
                        xmlSerializer.Serialize(writeStream, value, xmlSerializerNamespaces);
                    });

                    return task;
                }
                catch (Exception)
                {
                    return base.WriteToStreamAsync(type, value, writeStream, content, transportContext);
                }
            }
        }


        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //config.Formatters.XmlFormatter.UseXmlSerializer = true;



            //var xmlFormatter = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            //xmlFormatter.SetSerializer<Models.Mudrolije>(new XmlSerializer(typeof(Models.Mudrolije)));
            //xmlFormatter.Indent = true;
            //xmlFormatter.WriterSettings.OmitXmlDeclaration = false;


            config.Formatters.Clear();
            config.Formatters.Add(new PrilagodjavanjeXmlAtributaXmlMediaTypeFormatter());


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        
    }
    
}
