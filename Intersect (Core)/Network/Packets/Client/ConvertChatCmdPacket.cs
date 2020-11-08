using System;

namespace Intersect.Network.Packets.Client
{

    public class ConvertChatCmdPacket : CerasPacket
    {

        public ConvertChatCmdPacket(string str, Guid QuestId2, bool offerordesc)
        {
            Str = str;
            QuestId = QuestId2;
            OfferOrDesc = offerordesc;
        }

        public string Str { get; set; }

        public Guid QuestId { get; set; }

        public bool OfferOrDesc { get; set; }

    }

}
