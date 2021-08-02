using System;

namespace _25_inheritance
{
    public class Computers:ElectronicProducts
    {

        public void OSInfos(){
            Console.WriteLine("Operating system information is displayed");
        }

        public void RamSize(){
            Console.WriteLine("RAM size: ...");
        }
    }


    public class DesktopComputers:Computers
    {
        public void CaseInfos(){
            Console.WriteLine("Desktop Case Infos: ...");
        }
    }


    public class Laptops:Computers
    {
        public void ScreenSize(){
            Console.WriteLine("Screen Size: ...");
        }
    }
}