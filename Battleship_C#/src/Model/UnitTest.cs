using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BattleShip{
[TestFixture]
public class UnitTest
{
		//Tests if the hit is working correctly..
		[Test ()]
		public void TestHits()
		{
			BattleShipsGame BG = new BattleShipsGame ();
			Player P = new Player (BG);

			P.Ship (ShipName.Submarine).Hit ();
			P.Ship (ShipName.Submarine).Hit ();

			P.Ship(ShipName.Tug).Hit ();

			Assert.AreEqual (1, P.Ship(ShipName.Tug).Hits);
			Assert.AreEqual (2, P.Ship (ShipName.Submarine).Hits);
		}

		//Tests if all ships sizes are correct..
		[Test()]
		public void TestSizeOfShips()
		{
			BattleShipsGame BG = new BattleShipsGame ();
			Player P = new Player (BG);

			Assert.AreEqual (4, P.Ship (ShipName.Battleship).Size);
			Assert.AreEqual (1, P.Ship (ShipName.Tug).Size);
			Assert.AreNotEqual (9, P.Ship (ShipName.Destroyer).Size); // Should return false
		}

		//To check if the correct ShipName is getting passed..
		[Test()]
		public void TestShipNames()
		{
			BattleShipsGame BG = new BattleShipsGame ();
			Player P = new Player (BG);

			Assert.AreEqual("Aircraft Carrier", P.Ship(ShipName.AircraftCarrier).Name);
			Assert.AreEqual ("Tug", P.Ship (ShipName.Tug).Name);
			Assert.AreNotEqual ("WhatM8", P.Ship (ShipName.Destroyer).Name); //Should return false
		}

		//To check if Direction is being initiated when the object is created..
		[Test()]
		public void TestExistence()
		{
			BattleShipsGame BG = new BattleShipsGame ();
			Player P = new Player (BG);

			Assert.IsNotNull (P.Ship (ShipName.AircraftCarrier).Direction); 
			//Meaning that if it is not null returns true, the ship is placed in the grid.
		}
}
}