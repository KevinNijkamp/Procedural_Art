using UnityEngine;

namespace Demo {
	public class BuildTrigger : MonoBehaviour {
		public KeyCode BuildKey = KeyCode.Space;

		Shape Root;

		void Start() {
			Root=GetComponent<Shape>();
		}

		void Update() {
			if (Input.GetKeyDown(BuildKey)) {
				if (Root!=null) {
					Root.Generate();
				}
			}
		}
	}
}