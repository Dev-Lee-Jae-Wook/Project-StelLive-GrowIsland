using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
	public class CharacterLize : CharacterBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override StelLiveCharacterType characterType => StelLiveCharacterType.Lize;
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
			Debug.Log("리제 스폰함");
			yield return growObjectManager.GetGrowObject(GrowObjectType.Building).GrowCharacter(characterType);
		}
		#endregion

		#region Debug Methods
		#endregion

	}
}
