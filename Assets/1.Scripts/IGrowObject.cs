using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
    public interface IGrowObject
    {
        /// <summary>
        /// ĳ���Ϳ��� ��ȣ�ۿ����� �����ϴ� ����
        /// </summary>
        /// <param name="characterType"></param>
        /// <returns></returns>
        IEnumerator GrowCharacter(StelLiveCharacterType characterType);

        /// <summary>
        /// ������Ʈ���� ��ȣ�ۿ����� �����ϴ� ����
        /// </summary>
        /// <param name="growObjectType"></param>
        /// <returns></returns>
        IEnumerator GrowChainReaction(GrowObjectType growObjectType);
    }
}
