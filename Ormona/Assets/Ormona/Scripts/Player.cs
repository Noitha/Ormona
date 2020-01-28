using Ormona.Planets.Scripts;
using UnityEngine;

namespace Ormona.Scripts
{
    public class Player : MonoBehaviour
    {
        private Vector2 _keyboardInput;
        private Vector2 _mouseInput;

        public Rigidbody playerRigidBody;
        public Light pointLight;
        
        private Transform _playerTransform;
        public Camera playerCamera;

        public float normalSpeed;
        public float sprintSpeed;
        public float riseSpeed;
        public float mouseSensitivity;

        public float interactionDistance;
        public bool fastDestroy;
        public bool fastPlace;
        
        public Planet currentPlanet;
        public Vector3 cameraForward;
        public int buildDistance;
        public bool checkForNewPerimeter;

        public Vector3Int spawnPosition;
        
        public string placeEntityName;

        public int farAmount = 5;
        private float _rotationY;

        public bool useRigidbody;
        
        private void Start()
        {
            playerRigidBody = GetComponent<Rigidbody>();
            _playerTransform = transform;

            if (!useRigidbody)
            {
                Destroy(playerRigidBody); 
            }
            
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            _playerTransform.position = spawnPosition;
            
            _rotationY = 0;

            placeEntityName = "Grass";
        }

        private void Update()
        {
            Movement();

            if (checkForNewPerimeter)
            {
                CheckNewPerimeter();
            }

            if (Input.GetMouseButtonDown(0) || fastDestroy && Input.GetMouseButton(0))
            {
                var ray = playerCamera.ScreenPointToRay(Screen.safeArea.center);

                if (!Physics.Raycast(ray, out var hit, interactionDistance))
                {
                    return;
                }

                if (!hit.transform.CompareTag("EntityGroup"))
                {
                    return;
                }

                var worldPosition = hit.transform.parent.GetComponent<SceneChunk>().worldPosition;

                if (!currentPlanet.LoadedChunks.TryGetValue(worldPosition, out var hitChunk))
                {
                    return;
                }

                var lol = Vector3.zero;

                var hitPointX = hit.point.x;
                var hitPointY = hit.point.y;
                var hitPointZ = hit.point.z;

                var normalX = hit.normal.x;
                var normalY = hit.normal.y;
                var normalZ = hit.normal.z;

                lol.x = normalX > 0
                    ? Mathf.RoundToInt(hitPointX - .001f - worldPosition.x) % 8
                    : Mathf.RoundToInt(hitPointX + .001f - worldPosition.x) % 8;

                lol.y = normalY >= 0
                    ? (hitPointY - .001f - worldPosition.y) % 4
                    : (hitPointY + .001f - worldPosition.y) % 4;

                lol.z = normalZ > 0
                    ? Mathf.RoundToInt(hitPointZ - .001f - worldPosition.z) % 8
                    : Mathf.RoundToInt(hitPointZ + .001f - worldPosition.z) % 8;
                
                currentPlanet.DamageEntity(hitChunk, new Vector3Int((int) lol.x, (int) (lol.y / .5f), (int) lol.z));

                switch (lol.x)
                {
                    case 0:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Left, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                    case 7:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Right, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                }

                switch (lol.y)
                {
                    case 0:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Bottom, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                    case 7:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Top, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                }

                switch (lol.z)
                {
                    case 0:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Back, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                    case 7:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Front, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                }
            }

            if (Input.GetMouseButtonDown(1) || fastPlace && Input.GetMouseButton(1))
            {
                var ray = playerCamera.ScreenPointToRay(Screen.safeArea.center);

                if (!Physics.Raycast(ray, out var hit, interactionDistance))
                {
                    return;
                }

                if (!hit.transform.CompareTag("EntityGroup"))
                {
                    return;
                }

                var worldPosition = hit.transform.parent.GetComponent<SceneChunk>().worldPosition;

                if (!currentPlanet.LoadedChunks.TryGetValue(worldPosition, out var hitChunk))
                {
                    return;
                }

                var placeX = hit.point.x;
                var placeY = hit.point.y;
                var placeZ = hit.point.z;

                var normalX = hit.normal.x;
                var normalY = hit.normal.y;
                var normalZ = hit.normal.z;

                var localX = normalX > 0
                    ? Mathf.RoundToInt(placeX + .001f - worldPosition.x) % 8
                    : Mathf.RoundToInt(placeX - .001f - worldPosition.x) % 8;

                var localY = normalY >= 0
                    ? (placeY + .001f - worldPosition.y) % 4
                    : (placeY - .001f - worldPosition.y) % 4;

                var localZ = normalZ > 0
                    ? Mathf.RoundToInt(placeZ + .001f - worldPosition.z) % 8
                    : Mathf.RoundToInt(placeZ - .001f - worldPosition.z) % 8;
                
                var fr = normalY >= 0 ? placeY + .001f - worldPosition.y : placeY - .001f - worldPosition.y;

                var rest = hit.point.y % 1;
                if (rest > .5f && rest < 1f)
                {
                    localY = Mathf.CeilToInt(localY);
                }
                else if (rest > 0 && rest < .5f)
                {
                    localY = Mathf.FloorToInt(localY) + .5f;
                }

                var otherShit = (int) (localY / .5f);

                switch (localX)
                {
                    case -1:
                    {
                        Planet.SetEntity(currentPlanet.GetRelativeChunk(Direction.Left, hitChunk.WorldPosition),
                            new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                            new Vector3Int(7, otherShit, localZ));
                        hitChunk.Redraw(false);
                        return;
                    }
                    case 8:
                    {
                        Planet.SetEntity(currentPlanet.GetRelativeChunk(Direction.Right, hitChunk.WorldPosition),
                            new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                            new Vector3Int(0, otherShit, localZ));
                        hitChunk.Redraw(false);
                        return;
                    }
                }

                switch (fr)
                {
                    case -.001f:
                    {
                        Planet.SetEntity(currentPlanet.GetRelativeChunk(Direction.Bottom, hitChunk.WorldPosition),
                            new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                            new Vector3Int(localX, 7, localZ));
                        hitChunk.Redraw(false);
                        return;
                    }
                    case 4.001f:
                    {
                        Planet.SetEntity(currentPlanet.GetRelativeChunk(Direction.Top, hitChunk.WorldPosition),
                            new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                            new Vector3Int(localX, 0, localZ));
                        hitChunk.Redraw(false);
                        return;
                    }
                }

                switch (localZ)
                {
                    case -1:
                    {
                        Planet.SetEntity(currentPlanet.GetRelativeChunk(Direction.Back, hitChunk.WorldPosition),
                            new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                            new Vector3Int(localX, otherShit, 7));
                        hitChunk.Redraw(false);
                        return;
                    }
                    case 8:
                    {
                        Planet.SetEntity(currentPlanet.GetRelativeChunk(Direction.Front, hitChunk.WorldPosition),
                            new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                            new Vector3Int(localX, otherShit, 0));
                        hitChunk.Redraw(false);
                        return;
                    }
                }

                Planet.SetEntity(hitChunk,
                    new ChunkEntity(currentPlanet.planetEntities.GetEntityByLabel(placeEntityName)),
                    new Vector3Int(localX, otherShit, localZ));

                switch (localX)
                {
                    case 0:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Left, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                    case 7:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Right, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                }

                switch (fr)
                {
                    case -.001f:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Bottom, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                    case 4.001f:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Top, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                }

                switch (localZ)
                {
                    case 0:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Back, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                    case 7:
                    {
                        currentPlanet.GetRelativeChunk(Direction.Front, hitChunk.WorldPosition)?.Redraw(false);
                        break;
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                checkForNewPerimeter = !checkForNewPerimeter;
            }
            
            if (Input.GetKeyDown(KeyCode.L))
            {
                pointLight.enabled = !pointLight.enabled;
            }
        }

        private void Movement()
        {
            _keyboardInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            _mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            var speed = Time.deltaTime * (Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : normalSpeed) * _keyboardInput;
            
            _playerTransform.position += _playerTransform.forward * speed.y + _playerTransform.right * speed.x;

            if (Input.GetKey(KeyCode.Q))
            {
                var liftDown = transform.position;
                liftDown.y -= riseSpeed * Time.deltaTime;
                _playerTransform.position = liftDown;
            }
            
            if (Input.GetKey(KeyCode.E))
            {
                var liftUp = transform.position;
                liftUp.y += riseSpeed * Time.deltaTime;
                _playerTransform.position = liftUp;
            }

            var playerRotation = _playerTransform.localEulerAngles;
            playerRotation.y += _mouseInput.x * mouseSensitivity;
            _playerTransform.localEulerAngles = playerRotation;
            
            _rotationY += _mouseInput.y * mouseSensitivity;
            _rotationY = Mathf.Clamp(_rotationY, -90f, 90f);
            playerCamera.transform.localRotation = Quaternion.Euler(-_rotationY, 0f, 0f);
        }
        
        private void CheckNewPerimeter()
        {
            var ray = playerCamera.ScreenPointToRay(Screen.safeArea.center);

            if (Physics.Raycast(ray, out var hit, interactionDistance) && hit.transform.CompareTag("EntityGroup"))
            {
                var worldPosition = hit.transform.parent.GetComponent<SceneChunk>().worldPosition;
            
                StartCoroutine(currentPlanet.CreateChunk(worldPosition + new Vector3Int(-8, 0, 0), true));
                StartCoroutine(currentPlanet.CreateChunk(worldPosition + new Vector3Int(8, 0, 0), true));
                StartCoroutine(currentPlanet.CreateChunk(worldPosition + new Vector3Int(0, -4, 0), true));
                StartCoroutine(currentPlanet.CreateChunk(worldPosition + new Vector3Int(0, 4, 0), true));
                StartCoroutine(currentPlanet.CreateChunk(worldPosition + new Vector3Int(0, 0, -8), true));
                StartCoroutine(currentPlanet.CreateChunk(worldPosition + new Vector3Int(0, 0, 8), true));;
            }
            
            var position = _playerTransform.position;
            
            var playerChunkPosition = new Vector3Int
            (
                (int) position.x / 8 * 8,
                (int) position.y / 4 * 4,
                (int) position.z / 8 * 8
            );
            
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition, true));
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition + new Vector3Int(-8, 0, 0), true));
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition + new Vector3Int(8, 0, 0), true));
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition + new Vector3Int(0, -4, 0), true));
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition + new Vector3Int(0, 4, 0), true));
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition + new Vector3Int(0, 0, -8), true));
            StartCoroutine(currentPlanet.CreateChunk(playerChunkPosition + new Vector3Int(0, 0, 8), true));
            
            var cameraTransform = playerCamera.transform;
            
            for (var i = 1; i <= buildDistance; i++)
            {
                cameraForward = cameraTransform.position + i * 8 * cameraTransform.forward;
                
                var chunkPosition = new Vector3Int
                (
                    (int) cameraForward.x / 8 * 8,
                    (int) cameraForward.y / 4 * 4,
                    (int) cameraForward.z / 8 * 8
                );
                
                StartCoroutine(currentPlanet.CreateChunk(chunkPosition, true));
            }
        }


        /*private void OnCollisionEnter(Collision other)
        {
            if (!other.transform.CompareTag("EntityGroup"))
            {
                return;
            }

            var chunk = other.transform.GetComponent<SceneChunk>();
            
        }*/
    }
}