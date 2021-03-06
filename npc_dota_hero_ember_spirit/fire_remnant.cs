﻿// <copyright file="fire_remnant.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_ember_spirit
{
    public class ember_spirit_fire_remnant : CircleAbility, IHasModifier
    {
        public ember_spirit_fire_remnant(Ability ability)
            : base(ability)
        {
        }

        public bool HasInitialDamage { get; } = false;

        public string ModifierName { get; } = "modifier_ember_spirit_fire_remnant_charge_counter";
		}
	}
}