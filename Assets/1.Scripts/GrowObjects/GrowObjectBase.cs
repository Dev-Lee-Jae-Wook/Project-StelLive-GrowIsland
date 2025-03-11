using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace StelLiveGrowIsland
{
	public abstract class GrowObjectBase : MonoBehaviour
	{
		#region Inspector Field
		#endregion

		#region Fild
		private int _lv;
		private GrowObjectManager _growObjectManager;
		protected const int MaxLv = 5;
		protected StelLiveCharacterType mainCharacter;
		#endregion

		#region Properties
		public abstract GrowObjectType ObjectType { get; }
		public int Lv => _lv;
		protected GrowObjectManager Manager => _growObjectManager;
		public StelLiveCharacterType MainCharacter => mainCharacter;
		#endregion

		#region Events
		#endregion

		#region Unity Methods
		#endregion

		#region Public Methods
		public virtual void Initilize(GrowObjectManager manager)
		{
			_growObjectManager = manager;
			_lv = 0;
			mainCharacter = StelLiveCharacterType.None;
		}
		#endregion

		#region Private Methods

		#endregion

		#region Protectd Mehtods


		protected bool IsMainNone()
		{
			return mainCharacter == StelLiveCharacterType.None;
		}

		protected virtual void LvUp()
		{
			_lv++;
			Debug.Log($"{ObjectType}이 성장하였습니다.");
		}
		#endregion

		#region Coroutines
		/// <summary>
		/// 캐릭터와의 상호작용으로 성장하는 형태
		/// </summary>
		/// <param name="characterType"></param>
		/// <returns></returns>
		public abstract IEnumerator GrowCharacter(StelLiveCharacterType characterType);

		/// <summary>
		/// 오브젝트와의 상호작용으로 성장하는 형태
		/// </summary>
		/// <param name="growObjectType"></param>
		/// <returns></returns>
		public abstract IEnumerator GrowChainReaction(GrowObjectType growObjectType, StelLiveCharacterType characterType);
		#endregion

		#region Debug Methods
		#endregion
	}
}
