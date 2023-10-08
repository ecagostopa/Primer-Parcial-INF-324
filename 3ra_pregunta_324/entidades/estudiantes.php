<?php
	class estudiante{
		private $usuario;
		private $password;
		private $nombre;
		private $ap_paterno;
		private $ap_materno;
		private $semestre;
		private $locacion;
		private $genero;
		private $fec_nac;

		public function getUsuario(){
		return $this->usuario;
		}

		public function setUsuario($usuario){
			$this->usuario = $usuario;
		}

		public function getPassword(){
			return $this->password;
		}

		public function setPassword($password){
			$this->password = $password;
		}

		public function getNombre(){
			return $this->nombre;
		}

		public function setNombre($nombre){
			$this->nombre = $nombre;
		}

		public function getAp_paterno(){
			return $this->ap_paterno;
		}

		public function setAp_paterno($ap_paterno){
			$this->ap_paterno = $ap_paterno;
		}

		public function getAp_materno(){
			return $this->ap_materno;
		}

		public function setAp_materno($ap_materno){
			$this->ap_materno = $ap_materno;
		}

		public function getSemestre(){
			return $this->semestre;
		}

		public function setSemestre($semestre){
			$this->semestre = $semestre;
		}

		public function getLocacion(){
			return $this->locacion;
		}

		public function setLocacion($locacion){
			$this->locacion = $locacion;
		}

		public function getGenero(){
			return $this->genero;
		}

		public function setGenero($genero){
			$this->genero = $genero;
		}

		public function getFec_nac(){
			return $this->fec_nac;
		}

		public function setFec_nac($fec_nac){
			$this->fec_nac = $fec_nac;
		}
	}