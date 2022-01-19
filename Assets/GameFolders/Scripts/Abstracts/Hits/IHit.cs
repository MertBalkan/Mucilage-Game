using UnityEngine;

namespace MucilageGame.Abstracts.Hits
{
    public interface IHit
    {
        void Collide(Collider other);
    }
}