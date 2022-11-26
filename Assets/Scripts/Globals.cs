using UnityEngine;

namespace Globals {
    public struct Launch {
        public static Vector2 forceVector = new Vector2(0f, 20000f);
    }

    public struct Flipper {
        public static float speed = 1500f;
    }

    public struct Bumper {
        public static float force = 6000f;
    }
}