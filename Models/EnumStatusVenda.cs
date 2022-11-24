using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json.Serialization;

namespace tech_test_payment_api.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumStatusVenda
    {
        AguardandoPagamento,

       PagamentoAprovado,

        EnviadoParaTransportadora,

       Cancelada,
        
        Entregue,
    }
}