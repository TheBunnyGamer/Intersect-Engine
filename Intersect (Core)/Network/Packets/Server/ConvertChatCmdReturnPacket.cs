using System;

namespace Intersect.Network.Packets.Server
{

    public class ConvertChatCmdReturnPacket : CerasPacket
    {

        public ConvertChatCmdReturnPacket(string newstr, Guid questid2, bool offerordesc)
        {
            newstring = newstr;
            questid = questid2;
            OfferOrDesc = offerordesc;
        }

        public string newstring { get; set; }

        public Guid questid { get; set; }

        public bool OfferOrDesc { get; set; }

    }

}
