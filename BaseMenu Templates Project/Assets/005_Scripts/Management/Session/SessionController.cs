
using UnityEngine;
using AllosiusDev;
using Core;

namespace Core
{

    namespace Session
    {

        public class SessionController : Singleton<SessionController>
        {
            #region Fields

            private long m_SessionStartTime;
            private bool m_IsPaused;
            private BaseGameController m_Game;
            private float m_FPS;

            #endregion

            #region Properties

            public BaseGameController Game => m_Game;

            public long sessionStartTime
            {
                get
                {
                    return m_SessionStartTime;
                }
            }

            public float fps
            {
                get
                {
                    return m_FPS;
                }
            }

            #endregion

            #region Unity Functions
            protected override void Awake()
            {
                base.Awake();

                Configure();
            }

            private void Update()
            {
                if (m_IsPaused) return;
                m_Game.OnUpdate();
                m_FPS = Time.frameCount / Time.time;
            }
            #endregion

            #region Public Functions
            public void InitializeGame(BaseGameController _game)
            {
                m_Game = _game;
                m_Game.OnInit();
            }

            public void SetPause(bool value)
            {
                m_IsPaused = value;
            }
            #endregion

            #region Private Functions
            /// <summary>
            /// Initialize the singleton pattern!
            /// </summary>
            private void Configure()
            {
                StartSession();
            }

            private void StartSession()
            {
                m_SessionStartTime = EpochSeconds();
            }

            private long EpochSeconds()
            {
                var _epoch = new System.DateTimeOffset(System.DateTime.UtcNow);
                return _epoch.ToUnixTimeSeconds();
            }
            #endregion
        }
    }
}
