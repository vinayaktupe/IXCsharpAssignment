const selectors = {
	//FORMS
	loginForm: document.querySelector("#loginForm"),
	loginFormBtn: document.querySelector("#loginFormBtn"),
	registerForm: document.querySelector("#registerForm"),
	registerFormBtn: document.querySelector("#registerFormBtn"),

	email: document.querySelector("#email"),
	password: document.querySelector("#password"),
	passwordConfirm: document.querySelector("#passwordConfirm"),
	passwordIconContainer: document.querySelector("#passwordIconContainer"),
	passwordIcon: document.querySelector("#passwordIcon"),
};

if (selectors.loginForm) {
	selectors.loginForm.addEventListener("submit", (e) => {
		e.preventDefault();

		if (selectors.email.value === "john.doe@example.com" && selectors.password.value === "test@1234") {
			location.href = "home.html";
		}
	});

	selectors.passwordIconContainer.addEventListener("click", (e) => {
		selectors.passwordIconContainer.innerHTML = "";
		if (selectors.password.type === "password") {
			selectors.password.type = "text";
			selectors.passwordIconContainer.insertAdjacentHTML(
				"afterbegin",
				`<i class="form__icon-icon fa fa-eye-slash" aria-hidden="true" id="passwordIcon"></i>`,
			);
		} else {
			selectors.password.type = "password";
			selectors.passwordIconContainer.insertAdjacentHTML(
				"afterbegin",
				`<i class="form__icon-icon  fa fa-eye" aria-hidden="true" id="passwordIcon"></i>`,
			);
		}
	});
}

if (selectors.registerForm) {
	selectors.passwordIconContainer.addEventListener("click", (e) => {
		selectors.passwordIconContainer.innerHTML = "";
		if (selectors.passwordConfirm.type === "password") {
			selectors.passwordConfirm.type = "text";
			selectors.passwordIconContainer.insertAdjacentHTML(
				"afterbegin",
				`<i class="form__icon-icon fa fa-eye-slash" aria-hidden="true" id="passwordIcon"></i>`,
			);
		} else {
			selectors.passwordConfirm.type = "password";
			selectors.passwordIconContainer.insertAdjacentHTML(
				"afterbegin",
				`<i class="form__icon-icon  fa fa-eye" aria-hidden="true" id="passwordIcon"></i>`,
			);
		}
	});

	selectors.passwordConfirm.addEventListener("input", (e) => {
		if (e.target.value != "") {
			if (!(selectors.password.value != "" && e.target.value == selectors.password.value)) {
				e.target.setCustomValidity("Password not match");
			}
		}
	});
}
