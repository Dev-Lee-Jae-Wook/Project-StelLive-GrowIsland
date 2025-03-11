using System.Collections;

namespace StelLiveGrowIsland
{
	public class GrowObjectMine : GrowObjectBase
	{
		#region Inspector Field

		#endregion

		#region Fild
		#endregion

		#region Properties
		public override GrowObjectType ObjectType => GrowObjectType.Mining;
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods
		#endregion

		#region Protectd Mehtods
		#endregion

		#region Coroutines
		public override IEnumerator GrowChainReaction(GrowObjectType growObjectType, StelLiveCharacterType mainCharacter)
		{
			if (growObjectType == GrowObjectType.Building)
			{
				if (mainCharacter == StelLiveCharacterType.Nana && Lv == 0)
				{
					LvUp();
				}
			}
			else if (growObjectType == GrowObjectType.Farming)
			{
				if (mainCharacter == StelLiveCharacterType.Yuni && Lv == 2)
				{
					LvUp();
				}
			}
			else if (growObjectType == GrowObjectType.Fishing)
			{
				if (mainCharacter == StelLiveCharacterType.Hina && Lv == 3)
				{
					LvUp();
				}
			}

			yield return null;
		}

		public override IEnumerator GrowCharacter(StelLiveCharacterType characterType)
		{
			LvUp();
			if (IsMainNone() == true)
			{
				mainCharacter = characterType;
			}
			else if (mainCharacter != StelLiveCharacterType.GangZi && Lv == 5)
			{
				yield return Manager.GetGrowObject(GrowObjectType.Adventure).GrowChainReaction(ObjectType, mainCharacter);
				yield return Manager.GetGrowObject(GrowObjectType.Farming).GrowChainReaction(ObjectType, mainCharacter);
			}

			yield return null;
		}
	}
	#endregion

	#region Debug Methods
	#endregion


}
