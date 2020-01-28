using UnityEngine;

namespace Ormona.Scripts
{
    public class InputController : MonoBehaviour
    {
        public Player player;



        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                foreach (var chunk in player.currentPlanet.LoadedChunks)
                {
                    chunk.Value.Save();
                }
            }

            if (Input.GetKeyDown(KeyCode.U))
            {
                foreach (var chunk in player.currentPlanet.LoadedChunks)
                {
                    chunk.Value.Redraw(false);
                }
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                player.placeEntityName = "Grass";
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                player.placeEntityName = "Dirt";
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                player.placeEntityName = "Stone";
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                player.placeEntityName = "Pillar";

            }
            
            if (Input.GetKeyDown(KeyCode.O))
            {
                var pos = new Vector3Int
                {
                    x = (int) transform.position.x / 8 * 8,
                    y = (int) transform.position.y / 8 * 4,
                    z = (int) transform.position.z / 8 * 8,
                };
                
                if (player.currentPlanet.LoadedChunks.TryGetValue(pos, out var chunk))
                {
                    chunk.Redraw(false);
                }
            }
        }
    }
}