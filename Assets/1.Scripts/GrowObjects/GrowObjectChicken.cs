using System.Collections;

namespace StelLiveGrowIsland
{
	public class GrowObjectChicken : GrowObjectBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override GrowObjectType ObjectType => GrowObjectType.Farming;
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
			if(growObjectType == GrowObjectType.Adventure)
			{
				if(mainCharacter == StelLiveCharacterType.Tabi && Lv == 1)
				{
					LvUp();
				}
			}
			else if(growObjectType == GrowObjectType.Fishing)
			{
				if(mainCharacter == StelLiveCharacterType.Hina && Lv == 2)
				{
					LvUp();
				}
			}
			else if(growObjectType == GrowObjectType.Mining)
			{
				if(mainCharacter == StelLiveCharacterType.Shibuki && Lv == 4)
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

				if (mainCharacter == StelLiveCharacterType.Yuni)
				{
					yield return Manager.GetGrowObject(GrowObjectType.Building).GrowChainReaction(ObjectType, mainCharacter);
					yield return Manager.GetGrowObject(GrowObjectType.Mining).GrowChainReaction(ObjectType, mainCharacter);
				}
			}
			else if(mainCharacter != StelLiveCharacterType.Rin)
			{
				yield return Manager.GetGrowObject(GrowObjectType.Fishing).GrowChainReaction(ObjectType, mainCharacter);
				yield return Manager.GetGrowObject(GrowObjectType.Adventure).GrowChainReaction(ObjectType, mainCharacter);
			}
		}

		#endregion

		#region Debug Methods
		#endregion
	}
}
