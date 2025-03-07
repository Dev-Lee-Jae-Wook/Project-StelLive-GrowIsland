using System;
using UnityEngine;

namespace StelLiveGrowIsland
{
	public class GameManager : MonoBehaviour
	{
		#region Fild
		private int _turn;
		private const int EndTrun = 10;
		#endregion

		#region Properties
		#endregion

		#region Events
		public event Action OnTrunStart;
		public event Action<int> OnTrunEnd;
		public event Action<int> OnUpdateTrun;
		#endregion

		#region Unity Methods
		private void Awake()
		{
#if UNITY_EDITOR
			OnTrunStart += DrawTrun;
#endif
		}
		private void Start()
		{
			GameStart();
		}

		private void OnDestroy()
		{
#if UNITY_EDITOR
			OnTrunStart -= DrawTrun;
#endif
		}
		#endregion

		#region Public Methods
		/// <summary>
		/// ���� ù ���ۿ� ȣ���մϴ�.
		/// </summary>
		public void GameStart()
		{
			_turn = 0;
			Debug.Log("������ ���۵Ǿ����ϴ�.");
			OnTrunStart?.Invoke();
		}

		/// <summary>
		/// �÷��̾��� ������ ���� ���� ���� �� ȣ��˴ϴ�.
		/// </summary>
		public void TrunEnd()
		{
			//���� ������ ���� �׼��� ó���մϴ�.
			TrunEndAction();
			//ó���� ������ ���� ������ �Ѱ��ݴϴ�.
			NextTurn();
		}


		#endregion

		#region Private Methods
		/// <summary>
		/// ���� ���� ��Ű�� �� ���� ���۵Ǿ��ٰ� �̺�Ʈ�� ȣ���մϴ�.
		/// </summary>
		private void NextTurn()
		{
			_turn++;
			if (IsEndTrun() == false)
			{
				OnTrunStart?.Invoke();
				OnUpdateTrun?.Invoke(_turn);
			}
			//���� ���� ���� ��� ������ �����մϴ�.
			else
			{
				GameOver();
			}
		}

		private void GameOver()
		{
			Debug.Log("Game End");
		}

		private bool IsEndTrun()
		{
			return _turn == EndTrun;
		}

		//���� ������ �� ���� �׼��� ó���մϴ�.
		private void TrunEndAction()
		{
			
		}
		#endregion

		#region Coroutines
		#endregion

		#region Debug Methods
		private void DrawTrun()
		{
			Debug.Log($"���� �� : {_turn}");
		}
		#endregion

	}
}
