using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public class GrowObjectAdventure : GrowObjectBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override GrowObjectType ObjectType => GrowObjectType.Adventure;
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
			if (growObjectType == GrowObjectType.Fishing)
			{
				if(mainCharacter == StelLiveCharacterType.Hina && Lv == 1)
				{
					LvUp();
				}
			}
			else if(growObjectType == GrowObjectType.Farming)
			{
				if(mainCharacter == StelLiveCharacterType.Yuni && Lv == 3)
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
				if(mainCharacter == StelLiveCharacterType.Tabi)
				{
					yield return Manager.GetGrowObject(GrowObjectType.Building).GrowChainReaction(ObjectType, mainCharacter);
					yield return Manager.GetGrowObject(GrowObjectType.Fishing).GrowChainReaction(ObjectType, mainCharacter);
				}
			}
			else if(mainCharacter != StelLiveCharacterType.Riko)
			{
				yield return Manager.GetGrowObject(GrowObjectType.Farming).GrowChainReaction(ObjectType, mainCharacter);
				yield return Manager.GetGrowObject(GrowObjectType.Fishing).GrowChainReaction(ObjectType, mainCharacter);
				yield return Manager.GetGrowObject(GrowObjectType.Building).GrowChainReaction(ObjectType, mainCharacter);
			}

			yield return null;
		}

		#endregion

		#region Debug Methods
		#endregion
	}

}
