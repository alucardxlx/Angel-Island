/*
 *	This program is the CONFIDENTIAL and PROPRIETARY property 
 *	of Tomasello Software LLC. Any unauthorized use, reproduction or
 *	transfer of this computer program is strictly prohibited.
 *
 *      Copyright (c) 2004 Tomasello Software LLC.
 *	This is an unpublished work, and is subject to limited distribution and
 *	restricted disclosure only. ALL RIGHTS RESERVED.
 *
 *			RESTRICTED RIGHTS LEGEND
 *	Use, duplication, or disclosure by the Government is subject to
 *	restrictions set forth in subparagraph (c)(1)(ii) of the Rights in
 * 	Technical Data and Computer Software clause at DFARS 252.227-7013.
 *
 *	Angel Island UO Shard	Version 1.0
 *			Release A
 *			March 25, 2004
 */

/* Scripts/Mobiles/Monsters/Humanoid/Melee/BrigandArcher.cs
 * ChangeLog
 *  07/02/06, Kit
 *		InitBody/InitOutfit additions, changed fight range to 6! archers arent suppose to stand
 *		toe to toe.
 *  08/29/05 TK
 *		Changed AIType to Archer
 *	7/26/05, erlein
 *		Automated removal of AoS resistance related function calls. 1 lines removed.
 *	4/13/05, Kit
 *		Switch to new region specific loot model
 *	2/4/05, Adam
 *		Hookup PowderOfTranslocation drop rates to the CoreManagementConsole
 *	1/25/05, Adam
 *		Add PowderOfTranslocation as region specific loot 
 *		Brigands are the only ones that carry this loot.
 *	12/30/04, Adam
 *		Created by Adam.
 *		Cleanup name management, make use of Titles
 *			Show title when clicked = false
 */

using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server.Engines.IOBSystem;

namespace Server.Mobiles
{
	public class BrigandArcher : BaseCreature
	{
		[Constructable]
		public BrigandArcher()
			: base(AIType.AI_Archer, FightMode.All | FightMode.Weakest, 10, 6, 0.2, 0.4)
		{
			SpeechHue = Utility.RandomDyedHue();
			Title = "the brigand";
			Hue = Utility.RandomSkinHue();
			IOBAlignment = IOBAlignment.Brigand;
			ControlSlots = 3;

			SetStr(146, 200);
			SetDex(130, 170);
			SetInt(51, 65);

			SetDamage(23, 27);

			SetSkill(SkillName.Archery, 90.0, 100.5);
			SetSkill(SkillName.Macing, 60.0, 82.5);
			SetSkill(SkillName.Poisoning, 60.0, 82.5);
			SetSkill(SkillName.MagicResist, 57.5, 80.0);
			SetSkill(SkillName.Anatomy, 80.0, 92.5);
			SetSkill(SkillName.Tactics, 80.0, 92.5);

			InitBody();
			InitOutfit();

			Fame = 1500;
			Karma = -1500;

			PackItem(new Bandage(Utility.RandomMinMax(1, 15)));

		}

		public override bool AlwaysMurderer { get { return true; } }
		public override bool ShowFameTitle { get { return false; } }
		public override bool CanRummageCorpses { get { return Core.UOAI || Core.UOAR ? true : false; } }
		public override bool ClickTitle { get { return false; } }

		public override bool CanBandage { get { return true; } }
		public override TimeSpan BandageDelay { get { return TimeSpan.FromSeconds(Utility.RandomMinMax(10, 11)); } }

		public BrigandArcher(Serial serial)
			: base(serial)
		{
		}

		public override void InitBody()
		{
			if (this.Female = Utility.RandomBool())
			{
				Body = 0x191;
				Name = NameList.RandomName("female");

			}
			else
			{
				Body = 0x190;
				Name = NameList.RandomName("male");
			}
		}
		public override void InitOutfit()
		{
			WipeLayers();
			Item hair = new Item(Utility.RandomList(0x203B, 0x2049, 0x2048, 0x204A));
			hair.Hue = Utility.RandomNondyedHue();
			hair.Layer = Layer.Hair;
			hair.Movable = false;
			AddItem(hair);

			AddItem(new Boots(Utility.RandomNeutralHue()));
			AddItem(new FancyShirt());
			AddItem(new Bandana());
			AddItem(new Bow());

			if (Female)
				AddItem(new Skirt(Utility.RandomNeutralHue()));
			else
				AddItem(new ShortPants(Utility.RandomNeutralHue()));

		}

		public override void GenerateLoot()
		{
			if (Core.UOAI || Core.UOAR)
			{
				PackGold(170, 220);

				PackItem(new Arrow(Utility.RandomMinMax(20, 30)));

				// Froste: 12% random IOB drop
				if (0.12 > Utility.RandomDouble())
				{
					Item iob = Loot.RandomIOB();
					PackItem(iob);
				}

				if (IOBRegions.GetIOBStronghold(this) == IOBAlignment)
				{
					// 30% boost to gold
					PackGold(base.GetGold() / 3);
				}
			}
			else
			{
				if (Core.UOSP || Core.UOMO)
				{	// ai special
					if (Spawning)
					{
						PackGold(0);
					}
					else
					{
					}
				}
				else
				{
					// ai special
				}
			}
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}
