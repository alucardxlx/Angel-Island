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

/* Scripts/Mobiles/Vendors/SBInfo/SBRugMerchant.cs
 * ChangeLog
 *  04/02/05 TK
 *		Added yarn
 *	9/19/04, Pigpen
 *		Fixed price on Delucia Medium East Carpet.
 *	9/17/04, Pigpen
 *		Created SBRugMerchant.cs
 */

using System;
using System.Collections;
using Server.Items;

namespace Server.Mobiles
{
	public class SBRugMerchant : SBInfo
	{
		private ArrayList m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRugMerchant()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override ArrayList BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : ArrayList
		{
			public InternalBuyInfo()
			{
				Add(new GenericBuyInfo("Britain Small Carpet [east]", typeof(BritainSmallEastAddonDeed), 15000, 20, 0xAC6, 0x0));
				Add(new GenericBuyInfo("Britain Small Carpet [south]", typeof(BritainSmallSouthAddonDeed), 15000, 20, 0xAC6, 0x0));
				Add(new GenericBuyInfo("Britain Medium Carpet [East]", typeof(BritainMediumEastAddonDeed), 35000, 20, 0xAC6, 0x0));
				Add(new GenericBuyInfo("Britain Medium Carpet [south]", typeof(BritainMediumSouthAddonDeed), 35000, 20, 0xAC6, 0x0));
				Add(new GenericBuyInfo("Britain Large Carpet", typeof(BritainLargeAddonDeed), 60000, 20, 0xAC6, 0x0));
				Add(new GenericBuyInfo("Delucia Small Carpet [east]", typeof(DeluciaSmallEastAddonDeed), 25000, 20, 0xAEB, 0x0));
				Add(new GenericBuyInfo("Delucia Small Carpet [south]", typeof(DeluciaSmallSouthAddonDeed), 25000, 20, 0xAEB, 0x0));
				Add(new GenericBuyInfo("Delucia Medium Carpet [East]", typeof(DeluciaMediumEastAddonDeed), 50000, 20, 0xAEB, 0x0));
				Add(new GenericBuyInfo("Delucia Medium Carpet [south]", typeof(DeluciaMediumSouthAddonDeed), 50000, 20, 0xAEB, 0x0));
				Add(new GenericBuyInfo("Delucia Large Carpet", typeof(DeluciaLargeAddonDeed), 75000, 20, 0xAEB, 0x0));
				Add(new GenericBuyInfo("Magincia Small Carpet [east]", typeof(MaginciaSmallEastAddonDeed), 40000, 20, 0xAD1, 0x0));
				Add(new GenericBuyInfo("Magincia Small Carpet [south]", typeof(MaginciaSmallSouthAddonDeed), 40000, 20, 0xAD1, 0x0));
				Add(new GenericBuyInfo("Magincia Medium Carpet [East]", typeof(MaginciaMediumEastAddonDeed), 65000, 20, 0xAD1, 0x0));
				Add(new GenericBuyInfo("Magincia Medium Carpet [south]", typeof(MaginciaMediumSouthAddonDeed), 65000, 20, 0xAD1, 0x0));
				Add(new GenericBuyInfo("Magincia Large Carpet", typeof(MaginciaLargeAddonDeed), 100000, 20, 0xAD1, 0x0));
				Add(new GenericBuyInfo("Minoc Small Carpet [east]", typeof(MinocSmallEastAddonDeed), 10000, 20, 0x109D, 0x0));
				Add(new GenericBuyInfo("Minoc Small Carpet [south]", typeof(MinocSmallSouthAddonDeed), 10000, 20, 0x109D, 0x0));
				Add(new GenericBuyInfo("Minoc Medium Carpet [East]", typeof(MinocMediumEastAddonDeed), 20000, 20, 0x109D, 0x0));
				Add(new GenericBuyInfo("Minoc Medium Carpet [south]", typeof(MinocMediumSouthAddonDeed), 20000, 20, 0x109D, 0x0));
				Add(new GenericBuyInfo("Minoc Large Carpet", typeof(MinocLargeAddonDeed), 30000, 20, 0x109D, 0x0));
				Add(new GenericBuyInfo("Nujelm Small Carpet [east]", typeof(NujelmSmallEastAddonDeed), 15000, 20, 0xABD, 0x0));
				Add(new GenericBuyInfo("Nujelm Small Carpet [south]", typeof(NujelmSmallSouthAddonDeed), 15000, 20, 0xABD, 0x0));
				Add(new GenericBuyInfo("Nujelm Medium Carpet [East]", typeof(NujelmMediumEastAddonDeed), 35000, 20, 0xABD, 0x0));
				Add(new GenericBuyInfo("Nujelm Medium Carpet [south]", typeof(NujelmMediumSouthAddonDeed), 35000, 20, 0xABD, 0x0));
				Add(new GenericBuyInfo("Nujelm Large Carpet", typeof(NujelmLargeAddonDeed), 60000, 20, 0xABD, 0x0));
				Add(new GenericBuyInfo("Occlo Small Carpet [east]", typeof(OccloSmallEastAddonDeed), 25000, 20, 0xAED, 0x0));
				Add(new GenericBuyInfo("Occlo Small Carpet [south]", typeof(OccloSmallSouthAddonDeed), 25000, 20, 0xAED, 0x0));
				Add(new GenericBuyInfo("Occlo Medium Carpet [East]", typeof(OccloMediumEastAddonDeed), 50000, 20, 0xAED, 0x0));
				Add(new GenericBuyInfo("Occlo Medium Carpet [south]", typeof(OccloMediumSouthAddonDeed), 50000, 20, 0xAED, 0x0));
				Add(new GenericBuyInfo("Occlo Large Carpet", typeof(OccloLargeAddonDeed), 75000, 20, 0xAED, 0x0));
				Add(new GenericBuyInfo("Trinsic Small Carpet [east]", typeof(TrinsicSmallEastAddonDeed), 40000, 20, 0xADA, 0x0));
				Add(new GenericBuyInfo("Trinsic Small Carpet [south]", typeof(TrinsicSmallSouthAddonDeed), 40000, 20, 0xADA, 0x0));
				Add(new GenericBuyInfo("Trinsic Medium Carpet [East]", typeof(TrinsicMediumEastAddonDeed), 65000, 20, 0xADA, 0x0));
				Add(new GenericBuyInfo("Trinsic Medium Carpet [south]", typeof(TrinsicMediumSouthAddonDeed), 65000, 20, 0xADA, 0x0));
				Add(new GenericBuyInfo("Trinsic Large Carpet", typeof(TrinsicLargeAddonDeed), 100000, 20, 0xADA, 0x0));
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Core.UOAI || Core.UOAR || Core.UOMO)
				{	// balanced buyback system
					Add(typeof(DarkYarn));
					Add(typeof(LightYarn));
					Add(typeof(LightYarnUnraveled));
				}
			}
		}
	}
}

