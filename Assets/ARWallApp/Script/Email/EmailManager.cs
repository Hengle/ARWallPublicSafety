using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailManager : MonoBehaviour {
	EmailService _emailService;

	void Start() {
		string email = "publicsafety.tw@gmail.com";
		string password = "Safety2018";
		string company_name = "公共安全衛生局";

		_emailService = new EmailService(email, password, company_name);
	}


	public void SendEmail(string p_target_email) {
		if (_emailService != null) {
			
			
		}
	}

}
