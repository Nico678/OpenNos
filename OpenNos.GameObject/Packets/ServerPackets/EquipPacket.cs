﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNos.GameObject
{
    [PacketHeader("equip")]
    public class EquipPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte WeaponArmourUpgrade { get; set; }

        [PacketIndex(1)]
        public byte Design { get; set; }

        [PacketIndex(2)]
        public List<EquipSubPacket> EquipEntries { get; set; }

        #endregion
    }

    [PacketHeader("sub_equipment")] // actually no header rendered, avoid error
    public class EquipSubPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte Index { get; set; }

        [PacketIndex(1)]
        public int ItemVNum { get; set; }

        [PacketIndex(2)]
        public byte Rare { get; set; }

        [PacketIndex(4)]
        public byte Unknown { get; set; }

        [PacketIndex(3)]
        public byte Upgrade { get; set; }

        #endregion
    }
}
