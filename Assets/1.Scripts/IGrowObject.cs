using System.Collections;
using UnityEngine;

namespace StelLiveGrowIsland
{
    public interface IGrowObject
    {
        /// <summary>
        /// 캐릭터와의 상호작용으로 성장하는 형태
        /// </summary>
        /// <param name="characterType"></param>
        /// <returns></returns>
        IEnumerator GrowCharacter(StelLiveCharacterType characterType);

        /// <summary>
        /// 오브젝트와의 상호작용으로 성장하는 형태
        /// </summary>
        /// <param name="growObjectType"></param>
        /// <returns></returns>
        IEnumerator GrowChainReaction(GrowObjectType growObjectType);
    }
}
