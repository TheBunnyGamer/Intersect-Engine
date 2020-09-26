using System;

namespace Intersect.Network.Packets.Server
{

    public class HotbarSpellPacket : CerasPacket
    {

        public HotbarSpellPacket(Guid spelltohotbar)
        {
            SpellToHotbar = spelltohotbar;
        }

        public Guid SpellToHotbar { get; set; }

    }

}
