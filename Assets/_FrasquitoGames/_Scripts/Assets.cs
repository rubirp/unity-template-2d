using UnityEngine;

namespace FrasquitoGames
{

    /*
     * Global Asset references
     * Edit Asset references in the prefab _FrasquitoGames/_Resources/FrasquitoGamesAssets
     * */
    public class Assets : MonoBehaviour
    {

        // Internal instance reference
        private static Assets _i;

        // Instance reference
        public static Assets i
        {
            get
            {
                if(_i == null) _i = Instantiate(Resources.Load<Assets>("FrasquitoGamesAssets"));
                return _i;
            }
        }


        // All references
        public Sprite s_White;
        public Material m_White;

    }

}
