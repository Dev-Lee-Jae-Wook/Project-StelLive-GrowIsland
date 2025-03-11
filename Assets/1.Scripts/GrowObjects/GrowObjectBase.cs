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
			Debug.Log($"{ObjectType}�� �����Ͽ����ϴ�.");
		}
		#endregion

		#region Coroutines
		/// <summary>
		/// ĳ���Ϳ��� ��ȣ�ۿ����� �����ϴ� ����
		/// </summary>
		/// <param name="characterType"></param>
		/// <returns></returns>
		public abstract IEnumerator GrowCharacter(StelLiveCharacterType characterType);

		/// <summary>
		/// ������Ʈ���� ��ȣ�ۿ����� �����ϴ� ����
		/// </summary>
		/// <param name="growObjectType"></param>
		/// <returns></returns>
		public abstract IEnumerator GrowChainReaction(GrowObjectType growObjectType, StelLiveCharacterType characterType);
		#endregion

		#region Debug Methods
		#endregion
	}
}
