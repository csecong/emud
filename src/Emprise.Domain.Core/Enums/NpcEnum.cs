﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Emprise.Domain.Core.Enums
{
    public enum NpcStatusEnum
    {
        /// <summary>
        /// 空闲
        /// </summary>
        空闲 = 0,

        /// <summary>
        /// 死亡
        /// </summary>
        切磋 = 1,

        战斗 = 2,
        移动 = 3

    }

    /// <summary>
    /// Npc类型
    /// </summary>
    public enum NpcTypeEnum
    {
        /// <summary>
        /// 人物
        /// </summary>
        人物 = 1,

        /// <summary>
        /// 动物
        /// </summary>
        动物 = 2,

        /// <summary>
        /// 物品类型Npc
        /// </summary>
        物品 = 3
    }


    public enum NpcActionEnum
    {
        闲聊 = 1,
        给予 = 2,
        切磋 = 3,
        杀死 = 4

    }
}
