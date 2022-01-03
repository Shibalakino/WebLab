<!DOCTYPE html>
<html>
<head>
  <title>Username and password validation in PHP using AJAX</title>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
  <script type="text/javascript" src="ajaxValidation.js"></script>
  <style type="text/css">
    li{color: red;}
    #mb-4{margin-top: 200px}
    #mb-3{margin-bottom: 200px}
  </style>
</head>
<body>
  <div class="container col-md-5">
    <div class="mb-3">
      <label for="exampleFormControlInput1" class="form-label">Email address</label>
      <input type="email" class="form-control" id="userEmail" placeholder="name@example.com" onblur="validateEmail(this);">
    </div>
    <div class="mb-4">
      <label for="country" class="form-label">Country</label>
      <div class="find">
							<script src="https://code.jquery.com/jquery-3.6.0.js"></script>
							<script src="https://code.jquery.com/ui/1.13.0/jquery-ui.js"></script>
							<script>
								$(function () {
									var availableTags = [
										"Ukraine",
										"Germany",
										"France",
										"Serbia",
										"Italia",
										"USA",
										"Ephiopia",
									];
									$("#tags").autocomplete({
										source: availableTags,
									});
								});
							</script>
							<div class="">
								<input id="tags" />
							</div>
						</div>
    </div>
    <div class="mb-3">
      <label for="inputPassword" class="col-sm-2 col-form-label">Password</label>
      <input type="password" class="form-control" id="userPassword" placeholder="******">
    </div>
    <p id="message"></p>
    <div class="mb-3 col-md-4">
      <button class="form-control btn btn-danger" id="checkValidation">Validation Check</button>
    </div>
  </div>
</body>
</html>