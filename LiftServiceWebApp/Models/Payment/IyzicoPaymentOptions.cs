using Iyzipay;
using Microsoft.Extensions.Options;

namespace LiftService.Models.Payment
{
    public class IyzicoPaymentOptions : Options
    {
        public const string Key = "IyzicoOptions";
        public string ThreedsCallbackUrl { get; set; }
    }
}