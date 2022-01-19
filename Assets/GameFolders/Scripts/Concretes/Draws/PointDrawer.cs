using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MucilageGame.Concretes.Drawers
{
    public class PointDrawer : MonoBehaviour
    {
        [SerializeField] private GameObject[] _points;

        public GameObject[] Points => _points;

        private void Update()
        {
            DrawLineOnDebug();
        }

        private void DrawLineOnDebug()
        {
            Debug.DrawLine(Points[0].transform.position, Points[1].transform.position, Color.red);
            Debug.DrawLine(Points[1].transform.position, Points[2].transform.position, Color.red);
            Debug.DrawLine(Points[2].transform.position, Points[3].transform.position, Color.red);
            Debug.DrawLine(Points[3].transform.position, Points[0].transform.position, Color.red);
        }
    }
}