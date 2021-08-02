using System;

namespace _25_inheritance
{
    public class MobilePhones:ElectronicProducts
    {
        
        public  MobilePhones(){
            base.BrandInfos();
            base.PriceInfos();
            base.StockInfos();
        }
        protected void PhoneType(){
            Console.WriteLine("Phone type information will be displayed.");
        }

        protected void MakeCall(){
            Console.WriteLine("Making a call...");
        }

    }


    public class SmartPhones:MobilePhones
    {

        public SmartPhones(){
            base.MakeCall();
            base.PhoneType();
        }
        public void AndroidVersion(){
            Console.WriteLine("Android version information...");
        }
    }


    public class BasicPhones: MobilePhones
    {

        public BasicPhones(){
            // protected methods in base class
            base.PhoneType();        
            base.MakeCall();
        }
        public void SentMessage(){
            Console.WriteLine("Message sending was successful...");
        }
    }
}