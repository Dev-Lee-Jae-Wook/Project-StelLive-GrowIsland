using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
	public class CharacterShibuki : CharacterBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override StelLiveCharacterType characterType => StelLiveCharacterType.Shibuki;
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
			Debug.Log("시부키 스폰함");
			yield return null;
		}
		#endregion

		#region Debug Methods
		#endregion

	}
}
