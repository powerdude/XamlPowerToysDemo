namespace XamlPowerToysDemo.Model.Infrastructure {
    using System;
    using System.IO;
    using System.Xml.Serialization;

    public class Cloner {

        public static T DeepCopy<T>(T toClone) where T: class, new() {
            var serializer = new XmlSerializer(typeof(T));
            using (var sw = new StringWriter()) {
                serializer.Serialize(sw, toClone);
                var serializedString = sw.GetStringBuilder().ToString();

                using (var sr = new StringReader(serializedString)) {
                    return (T)serializer.Deserialize(sr);
                }
            }
        }

    }
}
