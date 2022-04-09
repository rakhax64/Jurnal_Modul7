using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Modul7_1302194084
{
    internal class BankTransferConfig
    {

        public string lang { get; set; }

        public transfers transfer { get; set; }
        public string methods { get; set; }
        public confirmation confirmation { get; set; }
        public BankTransferConfig() { }
        public BankTransferConfig(string lang, transfers transfer, string methods, confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }

    }
    class transfers
    {
        public string threshold { get; set; }
        public string low_fee { get; set; }
        public string high_fee { get; set; }
        public transfer() { }
        public transfer(string threshold, string low_fee, string high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }

    }
    class confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
        public confirmation() { }
        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
