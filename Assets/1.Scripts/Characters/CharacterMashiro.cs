using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
	public class CharacterMashiro : CharacterBase
	{
		#region Inspector Field
		#endregion

		#region Fild
		#endregion

		#region Properties
		public override StelLiveCharacterType characterType => StelLiveCharacterType.Mashiro;
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
			Debug.Log("���÷� ������");
			yield return growObjectManager.GetGrowObject(GrowObjectType.Fishing).GrowCharacter(characterType);
		}
		#endregion

		#region Debug Methods
		#endregion

	}
}
