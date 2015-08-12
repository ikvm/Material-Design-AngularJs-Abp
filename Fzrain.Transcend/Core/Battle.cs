﻿using System;
using System.Collections.Generic;
using Abp.Domain.Entities;

namespace Fzrain.Transcend.Core
{
  public   class Battle:Entity
    {
        public int BattleType { get; set; }
        public long GameId { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        public int IsWin { get; set; }
        public int ChampionId { get; set; }
        public int ContributeOrder { get; set; }
       public virtual  ICollection<Record> Records { get; set; }
      
    }
}
