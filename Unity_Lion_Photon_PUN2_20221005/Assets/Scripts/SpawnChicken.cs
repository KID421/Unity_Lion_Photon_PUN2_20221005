using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ͦ��N��
    /// </summary>
    public class SpawnChicken : MonoBehaviour
    {
        [SerializeField, Header("�N��")]
        private GameObject prefabChicken;
        [SerializeField, Header("�ͦ��W�v"), Range(0, 5)]
        private float intervalSpawn = 2.5f;
        [SerializeField, Header("�ͦ��I")]
        private Transform[] spawnPoints;
    }
}
