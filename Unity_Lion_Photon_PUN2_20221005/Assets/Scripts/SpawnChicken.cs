using UnityEngine;

namespace KID
{
    /// <summary>
    /// 生成烤雞
    /// </summary>
    public class SpawnChicken : MonoBehaviour
    {
        [SerializeField, Header("烤雞")]
        private GameObject prefabChicken;
        [SerializeField, Header("生成頻率"), Range(0, 5)]
        private float intervalSpawn = 2.5f;
        [SerializeField, Header("生成點")]
        private Transform[] spawnPoints;
    }
}
