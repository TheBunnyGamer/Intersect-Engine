using System;

namespace Intersect.Network.Packets.Server
{

    public class RemoveHotbarSpellPacket : CerasPacket
    {

        public RemoveHotbarSpellPacket(Guid spelltohotbar)
        {
            SpellToHotbar = spelltohotbar;
        }

        public Guid SpellToHotbar { get; set; }

    }

}
