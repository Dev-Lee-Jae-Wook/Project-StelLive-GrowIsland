using System.Collections;

namespace StelLiveGrowIsland
{
	public class GrowObjectStick : GrowObjectBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override GrowObjectType ObjectType => GrowObjectType.Fishing;
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
			if (growObjectType == GrowObjectType.Adventure)
			{
				if (mainCharacter == StelLiveCharacterType.Tabi && Lv == 0)
				{
					LvUp();
				}
				else if (mainCharacter == StelLiveCharacterType.Tabi && Lv == 2)
				{
					LvUp();
				}
			}
			else if (growObjectType == GrowObjectType.Farming)
			{
				if (mainCharacter == StelLiveCharacterType.Yuni && Lv == 4)
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
				if (mainCharacter == StelLiveCharacterType.Hina)
				{
					yield return Manager.GetGrowObject(GrowObjectType.Adventure).GrowChainReaction(ObjectType, mainCharacter);
				}
			}
			else if (mainCharacter != StelLiveCharacterType.Mashiro)
			{
				if (Lv == 4)
				{
					yield return Manager.GetGrowObject(GrowObjectType.Farming).GrowChainReaction(ObjectType, MainCharacter);
					yield return Manager.GetGrowObject(GrowObjectType.Mining).GrowChainReaction(ObjectType, MainCharacter);
				}
			}

			yield return null;
		}
	}
	#endregion

	#region Debug Methods
	#endregion


}
