using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
	public class CharacterYuni : CharacterBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override StelLiveCharacterType characterType => StelLiveCharacterType.Yuni;
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		#endregion

		#region Public Methods
		#endregion

		#region Private Methods
		#endregion

		#region Coroutines
		public override IEnumerator Action()
		{
			Debug.Log("유니 스폰함");
			yield return growObjectManager.GetGrowObject(GrowObjectType.Farming).GrowCharacter(characterType);
		}
		#endregion

		#region Debug Methods
		#endregion

	}
}
