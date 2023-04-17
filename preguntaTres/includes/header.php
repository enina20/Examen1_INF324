

<!DOCTYPE html>
<html lang="en">
<head>
<!-- basic -->
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<!-- mobile metas -->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta name="viewport" content="initial-scale=1, maximum-scale=1">
<!-- site metas -->
<title>FACULTAD DE CIENCIAS PURAS Y NATURALES</title>
<meta name="keywords" content="">
<meta name="description" content="">
<meta name="author" content="">
<!-- site icons -->
<link rel="icon" href="images/facultad_logo.png" type="image/gif" />
<!-- bootstrap css -->
<link rel="stylesheet" href="css/bootstrap.min.css" />
<!-- Site css -->
<link rel="stylesheet" href="css/style.css" />
<!-- responsive css -->
<link rel="stylesheet" href="css/responsive.css" />
<!-- colors css -->
<link rel="stylesheet" href="css/colors1.css" />
<!-- custom css -->
<link rel="stylesheet" href="css/custom.css" />
<!-- wow Animation css -->
<link rel="stylesheet" href="css/animate.css" />
<!-- revolution slider css -->
<link rel="stylesheet" type="text/css" href="revolution/css/settings.css" />
<link rel="stylesheet" type="text/css" href="revolution/css/layers.css" />
<link rel="stylesheet" type="text/css" href="revolution/css/navigation.css" />

</head>
<body id="default_theme" class="it_service">
<!-- loader -->
<div class="bg_load"> <img class="loader_animation" src="images/loaders/loader_1.png" alt="#" /> </div>
<!-- end loader -->
<!-- header -->
<header id="default_header" class="header_style_1">
  <!-- header bottom -->
  <div class="header_bottom">
    <div class="container">
      <div class="row">
        <div class="col-lg-3 col-md-12 col-sm-12 col-xs-12">
          <!-- logo start -->
          <div class="logo"> <a href="index.php"><img src="images/facultad_logo.png" alt="logo" /></a> </div>         
          <!-- logo end -->
        </div>
        <div class="col-lg-9 col-md-12 col-sm-12 col-xs-12">
          <!-- menu start -->
          <div class="menu_side">
            <div id="navbar_menu">
              <ul class="first-ul">
                <li><a class="active" href="index.php">Inicio</a></li>
                <li><a href="index.php#carreras">Carreras</a></li>
                <li><a href="index.php#acerca-de-nosotros">Conocenos</a></li> 
                <li><a href="index.php">Contactanos</a></li>
                <li>
                  <a href="#">
                  <i class="fa fa-user"></i>
                  <span>Bienvenido <?php echo $_SESSION['username']; ?></span>
                  </a>
                  <ul class="submenu">
                    <li><a href="cerrar_sesion.php">Cerrar sesión</a></li>
                  </ul>
                </li>

              </ul>
            </div>
          </div>
          <!-- menu end -->
        </div>
      </div>
    </div>
  </div>
  <!-- header bottom end -->
</header>
<!-- end header -->