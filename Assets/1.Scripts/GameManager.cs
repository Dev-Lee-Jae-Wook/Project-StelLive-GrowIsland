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
		/// 게임 첫 시작에 호출합니다.
		/// </summary>
		public void GameStart()
		{
			_turn = 0;
			Debug.Log("게임이 시작되었습니다.");
			OnTrunStart?.Invoke();
		}

		/// <summary>
		/// 플레이어의 조작이 끝나 턴을 끝낼 때 호출됩니다.
		/// </summary>
		public void TrunEnd()
		{
			//턴이 끝나고 월드 액션을 처리합니다.
			TrunEndAction();
			//처리가 끝나면 다음 턴으로 넘겨줍니다.
			NextTurn();
		}


		#endregion

		#region Private Methods
		/// <summary>
		/// 턴을 증가 시키고 새 턴이 시작되었다고 이벤트를 호출합니다.
		/// </summary>
		private void NextTurn()
		{
			_turn++;
			if (IsEndTrun() == false)
			{
				OnTrunStart?.Invoke();
				OnUpdateTrun?.Invoke(_turn);
			}
			//다음 턴이 없는 경우 게임을 종료합니다.
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

		//턴이 끝났을 때 월드 액션을 처리합니다.
		private void TrunEndAction()
		{
			
		}
		#endregion

		#region Coroutines
		#endregion

		#region Debug Methods
		private void DrawTrun()
		{
			Debug.Log($"현재 턴 : {_turn}");
		}
		#endregion

	}
}
