using System.Collections;
using Unity.VisualScripting;

namespace StelLiveGrowIsland
{
	public class GrowObjectWorkBench : GrowObjectBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override GrowObjectType ObjectType => GrowObjectType.Building;
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
			if(growObjectType == GrowObjectType.Farming)
			{
				if(mainCharacter == StelLiveCharacterType.Yuni && Lv == 1)
				{
					LvUp();
				}
			}
			else if(growObjectType == GrowObjectType.Adventure)
			{
				if(mainCharacter == StelLiveCharacterType.Tabi && Lv == 2)
				{
					LvUp();
				}
				else if(mainCharacter == StelLiveCharacterType.Tabi && Lv == 3)
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
				if (mainCharacter == StelLiveCharacterType.Nana)
				{
					yield return Manager.GetGrowObject(GrowObjectType.Mining).GrowChainReaction(ObjectType, mainCharacter);
				}
			}
		}
		#endregion

		#region Debug Methods
		#endregion



	}
}
