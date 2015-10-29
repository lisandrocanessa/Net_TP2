# SQL Manager Lite for MySQL 5.5.0.45357
# ---------------------------------------
# Host     : localhost
# Port     : 3306
# Database : academia


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;

SET FOREIGN_KEY_CHECKS=0;

DROP DATABASE IF EXISTS `academia`;

CREATE DATABASE `academia`
    CHARACTER SET 'latin1'
    COLLATE 'latin1_swedish_ci';

USE `academia`;

#
# Dropping database objects
#

DROP TABLE IF EXISTS `privilegios`;
DROP TABLE IF EXISTS `modulos_usuarios`;
DROP TABLE IF EXISTS `modulos`;
DROP TABLE IF EXISTS `docentes_cursos`;
DROP TABLE IF EXISTS `alumnos_inscripciones`;
DROP TABLE IF EXISTS `personas`;
DROP TABLE IF EXISTS `tipos_personas`;
DROP TABLE IF EXISTS `cursos`;
DROP TABLE IF EXISTS `comisiones`;
DROP TABLE IF EXISTS `materias`;
DROP TABLE IF EXISTS `planes`;
DROP TABLE IF EXISTS `especialidades`;

#
# Structure for the `especialidades` table : 
#

CREATE TABLE `especialidades` (
  `desc_especialidad` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_especialidad` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `state` INTEGER(1) DEFAULT 1,
  PRIMARY KEY (`id_especialidad`) USING BTREE
) ENGINE=InnoDB
AUTO_INCREMENT=2 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `planes` table : 
#

CREATE TABLE `planes` (
  `desc_plan` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_especialidad` INTEGER(11) DEFAULT NULL,
  `id_plan` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `state` INTEGER(1) DEFAULT 1,
  PRIMARY KEY (`id_plan`) USING BTREE,
  KEY `id_especialidad_fk_idx` (`id_especialidad`) USING BTREE,
  CONSTRAINT `planes_fk` FOREIGN KEY (`id_especialidad`) REFERENCES `especialidades` (`id_especialidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=3 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `materias` table : 
#

CREATE TABLE `materias` (
  `desc_materia` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `hs_semanales` INTEGER(11) DEFAULT NULL,
  `hs_totales` INTEGER(11) DEFAULT NULL,
  `id_plan` INTEGER(11) DEFAULT NULL,
  `id_materia` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `state` INTEGER(1) DEFAULT 1,
  PRIMARY KEY (`id_materia`) USING BTREE,
  KEY `materias_fk_idx` (`id_plan`) USING BTREE,
  CONSTRAINT `materias_fk` FOREIGN KEY (`id_plan`) REFERENCES `planes` (`id_plan`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=4 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `comisiones` table : 
#

CREATE TABLE `comisiones` (
  `anio_especialidad` INTEGER(11) DEFAULT NULL,
  `desc_comision` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_plan` INTEGER(11) DEFAULT NULL,
  `id_comision` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `state` INTEGER(1) DEFAULT 1,
  PRIMARY KEY (`id_comision`) USING BTREE,
  KEY `comisiones_fk_idx` (`id_plan`) USING BTREE,
  CONSTRAINT `comisiones_fk` FOREIGN KEY (`id_plan`) REFERENCES `planes` (`id_plan`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `cursos` table : 
#

CREATE TABLE `cursos` (
  `anio_calendario` INTEGER(11) DEFAULT NULL,
  `cupo` INTEGER(11) DEFAULT NULL,
  `descripcion` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_comision` INTEGER(11) DEFAULT NULL,
  `id_materia` INTEGER(11) DEFAULT NULL,
  `id_curso` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `state` INTEGER(1) DEFAULT 1,
  PRIMARY KEY (`id_curso`) USING BTREE,
  KEY `id_comision` (`id_comision`) USING BTREE,
  KEY `cursos_fk1_idx` (`id_materia`) USING BTREE,
  CONSTRAINT `cursos_fk1` FOREIGN KEY (`id_materia`) REFERENCES `materias` (`id_materia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `cursos_fk2` FOREIGN KEY (`id_comision`) REFERENCES `comisiones` (`id_comision`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `tipos_personas` table : 
#

CREATE TABLE `tipos_personas` (
  `id_tipo_persona` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `desc_tipo_persona` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  PRIMARY KEY (`id_tipo_persona`) USING BTREE
) ENGINE=InnoDB
AUTO_INCREMENT=4 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `personas` table : 
#

CREATE TABLE `personas` (
  `apellido` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `direccion` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `email` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `fecha_nac` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_plan` INTEGER(11) DEFAULT NULL,
  `legajo` INTEGER(11) DEFAULT NULL,
  `nombre` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `telefono` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_tipo_persona` INTEGER(11) DEFAULT NULL,
  `id_persona` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `state` INTEGER(1) DEFAULT 1,
  `clave` VARCHAR(45) COLLATE latin1_swedish_ci DEFAULT NULL,
  `habilitado` TINYINT(1) DEFAULT NULL,
  `nombre_usuario` VARCHAR(45) COLLATE latin1_swedish_ci DEFAULT NULL,
  PRIMARY KEY (`id_persona`) USING BTREE,
  KEY `personas_fk1_idx` (`id_plan`) USING BTREE,
  KEY `personas_fk2_idx` (`id_tipo_persona`) USING BTREE,
  CONSTRAINT `personas_fk1` FOREIGN KEY (`id_plan`) REFERENCES `planes` (`id_plan`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `personas_fk2` FOREIGN KEY (`id_tipo_persona`) REFERENCES `tipos_personas` (`id_tipo_persona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=2 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `alumnos_inscripciones` table : 
#

CREATE TABLE `alumnos_inscripciones` (
  `condicion` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_alumno` INTEGER(11) DEFAULT NULL,
  `id_curso` INTEGER(11) DEFAULT NULL,
  `nota` INTEGER(11) DEFAULT NULL,
  `id_inscripcion` INTEGER(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_inscripcion`) USING BTREE,
  KEY `alumnos_inscripciones_fk1_idx` (`id_curso`) USING BTREE,
  KEY `alumnos_inscripciones_fk2_idx` (`id_alumno`) USING BTREE,
  CONSTRAINT `alumnos_inscripciones_fk1` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `alumnos_inscripciones_fk2` FOREIGN KEY (`id_alumno`) REFERENCES `personas` (`id_persona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `docentes_cursos` table : 
#

CREATE TABLE `docentes_cursos` (
  `cargo` VARCHAR(25) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_curso` INTEGER(11) DEFAULT NULL,
  `id_docente` INTEGER(11) DEFAULT NULL,
  `id_dictado` INTEGER(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_dictado`) USING BTREE,
  KEY `id_curso` (`id_curso`) USING BTREE,
  KEY `docentes_cursos_fk2_idx` (`id_docente`) USING BTREE,
  CONSTRAINT `docentes_cursos_fk1` FOREIGN KEY (`id_curso`) REFERENCES `cursos` (`id_curso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `docentes_cursos_fk2` FOREIGN KEY (`id_docente`) REFERENCES `personas` (`id_persona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `modulos` table : 
#

CREATE TABLE `modulos` (
  `desc_modulo` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `ejecuta` VARCHAR(50) COLLATE latin1_swedish_ci DEFAULT NULL,
  `id_modulo` INTEGER(11) NOT NULL,
  PRIMARY KEY (`id_modulo`) USING BTREE
) ENGINE=InnoDB
CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `modulos_usuarios` table : 
#

CREATE TABLE `modulos_usuarios` (
  `id_modulo` INTEGER(11) DEFAULT NULL,
  `id_usuario` INTEGER(11) DEFAULT NULL,
  `alta` TINYINT(1) DEFAULT NULL,
  `baja` TINYINT(1) DEFAULT NULL,
  `modificacion` TINYINT(1) DEFAULT NULL,
  `consulta` TINYINT(1) DEFAULT NULL,
  `id_modulo_usuario` INTEGER(11) NOT NULL,
  PRIMARY KEY (`id_modulo_usuario`) USING BTREE,
  KEY `id_modulo` (`id_modulo`) USING BTREE,
  KEY `id_usuario` (`id_usuario`) USING BTREE,
  CONSTRAINT `modulos_usuarios_fk1` FOREIGN KEY (`id_modulo`) REFERENCES `modulos` (`id_modulo`)
) ENGINE=InnoDB
CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Structure for the `privilegios` table : 
#

CREATE TABLE `privilegios` (
  `id_privilegio` INTEGER(11) NOT NULL AUTO_INCREMENT,
  `descripcion` VARCHAR(45) COLLATE latin1_swedish_ci DEFAULT NULL,
  PRIMARY KEY (`id_privilegio`) USING BTREE
) ENGINE=InnoDB
AUTO_INCREMENT=1 CHARACTER SET 'latin1' COLLATE 'latin1_swedish_ci'
;

#
# Data for the `especialidades` table  (LIMIT 0,500)
#

INSERT INTO `especialidades` (`desc_especialidad`, `id_especialidad`, `state`) VALUES
  ('Ingenieria en Sistemas de Informacion',1,1);
COMMIT;

#
# Data for the `planes` table  (LIMIT 0,500)
#

INSERT INTO `planes` (`desc_plan`, `id_especialidad`, `id_plan`, `state`) VALUES
  ('Plan 2008',1,1,1),
  ('Plan 2011',1,2,1);
COMMIT;

#
# Data for the `materias` table  (LIMIT 0,500)
#

INSERT INTO `materias` (`desc_materia`, `hs_semanales`, `hs_totales`, `id_plan`, `id_materia`, `state`) VALUES
  ('Arquitectura de las Computadoras',10,100,1,1,1),
  ('Java',5,250,1,2,1),
  ('Matematica Discreta',20,400,2,3,1);
COMMIT;

#
# Data for the `tipos_personas` table  (LIMIT 0,500)
#

INSERT INTO `tipos_personas` (`id_tipo_persona`, `desc_tipo_persona`) VALUES
  (1,'Administrador'),
  (2,'Alumno'),
  (3,'Docente');
COMMIT;

#
# Data for the `personas` table  (LIMIT 0,500)
#

INSERT INTO `personas` (`apellido`, `direccion`, `email`, `fecha_nac`, `id_plan`, `legajo`, `nombre`, `telefono`, `id_tipo_persona`, `id_persona`, `state`, `clave`, `habilitado`, `nombre_usuario`) VALUES
  ('Canessa','asdasd','lcanessa','123',NULL,123,'lisandro','123',1,1,1,'admin',1,'admin');
COMMIT;



/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;