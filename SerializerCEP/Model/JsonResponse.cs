using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializerCEP.Model
{
    [DataContract]
    public class JsonResponse
    {
        [DataMember]
        public string cep { get; set; }

        [DataMember]
        public string logradouro { get; set; }

        [DataMember]
        public string complemento { get; set; }

        [DataMember]
        public string bairro { get; set; }

        [DataMember]
        public string localidade { get; set; }

        [DataMember]
        public string uf { get; set; }

        [DataMember]
        public string ibge { get; set; }

        [DataMember]
        public string gia { get; set; }
    }
}
