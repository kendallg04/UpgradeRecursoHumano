using System;

namespace SIGRH.Models;

public class Constant
{
    //Documento boletas de asistencia
    public const int DocumentoBoleta = 111;
    //Documento estatus documento
    public const int DocumentoEstatus = 218;
    //Dias maximos captura anticipada vacaciones
    public const int IntParametro26 = 26;
    //Vacaciones Institucionales
    public const int IntParametro24 = 24;
    //Dias maximos captura posterior vacaciones
    public const int IntParametro27 = 27;
    //Dias maximos duracion vacaciones
    public const int IntParametro28 = 28;
    //Notificación de aprobación de Boleta
    public const int IntParametro192 = 192;
    //Notificación de rechazar Boleta
    public const int IntParametro193 = 193;
    //Parametro temporal en el modulo de asistencia, para determinar la unidad con rol de excepción que no pueda visualizar la pantallade Asignación de Horario 
    public const int IntParametro195 = 195;
    //Longitud Minima de contraseña R.R
    public const int LongitudMinimaContrasenia = 6;
    //Longitud Maxima de contraseña R.R
    public const int LogintudMaximaContrasenia = 13;
    //Número de la aplicación establecido en la bd de admseg
    public const int AplicacionId = 18;
    //Rol de Colaborador
    public const int RolColaborador = 1330;
    //Rol de Autoridad
    public const int RolAutoridad = 1331;
    //Rol de Capturador
    public const int RolCapturador = 1332;
    // Rol de Asistentes Servicios
    public const int RolAsistenteServicio = 1372;
    // Rol de Programa Salud Autoridad
    public const int RolProgramaSaludAutoridad = 1375;
    // Rol de Administrador de Documentos
    public const int RolAdministradorDocumento = 1378;
    //El estatus secundario inicial en el registro de boletas
    public const int EstatusSet = 7;
    //El estatus inicial en el registro de boletas
    public const int EstatusSetPendienteAprobacion = 15;
    //El estatus inicial en el registro de boletas para oficial de asistente
    public const int EstatusSetAprobado = 12;
    //Estatus Tramitado
    public const int EstatusSetTramitado = 9;
    //Estatus En Tramitado
    public const int EstatusSetEnTramitado = 111;
    //Estatus Verificado
    public const int EstatusSetVerificado = 189;
    //Documento de boletas de vacaciones
    public const int BoletaVacaciones = 126;
    //Documento de boletas de enfermedades
    public const int BoletaEnfermedad = 127;
    //Documento de boletas de tiempos
    public const int BoletaTiempo = 143;
    //Documento de boletas otras
    public const int BoletaOtra = 128;
    //Documento de servicios
    public const int DocumentoServicio = 101;
    //Documento Tipo de permisos especiales
    public const int PermisosEspecial = 150;
    //El estatus inicial en los filtros de de boletas
    public const int EstatusSetCon = 0;
    //Documento Tipo Ley 42 Equiparación de Oportunidades
    public const int Ley42EquiparacionOportunidad = 208;
    //Documento Tipo Ley 59
    public const int Ley59 = 209;
    //Documento Tipo Ley 62 Articulo 86
    public const int Ley62Articulo86 = 207;
    //Rol Oficial de Asistencia
    public const int RolOficialAsistencia = 591;
    //Rol de Excepciones
    public const int RolExcepcion = 1344;
    //Rol de Programa Salud
    public const int RolProgramaSalud = 1352;
    //Documento Tipo Duelo
    public const int Duelo = 241;
    //Documento Tipo Adiestramiento
    public const int Adiestramiento = 236;
    //Documento Tipo Matrimonio
    public const int Matrimonio = 240;
    //Documento Tipo Jurado de Conciencia
    public const int JuradoConciencia = 295;
    //Documento Tipo Licitación de Institución
    public const int LicitacionInstitucion = 300;
    //Documento Tipo Covid-19
    public const int Covid19 = 193;
    //Documento Tipo Capacitacion
    public const int Capacitacion = 462;
    //Documento Tipo Capacitacion
    public const int TipoDuelo = 241;
    //Documento Tipo Misión Oficial
    public const int MisionOficial = 237;
    //Documento Tipo Cumpleaños
    public const int Cumpleanos = 239;
    //Documento Tipo Suspensiones sin sueldo
    public const int SuspensionSinSueldo = 166;
    //Documento Tipo Evento Especiales de la institución/ley
    public const int EventoEspecialInstitucionLey = 161;
    //Documento Tipo Fumigación
    public const int Fumigacion = 165;
    //Documento Tipo Cierre de Calles / Desalojo (Manifestaciones o Disturbios)
    public const int CierreCalleDesalojo = 245;
    //Documento Tipo Huelga del Servicio del Transporte Publico
    public const int HuelgaTransporte = 246;
    //Documento Tipo Desastres Naturales (Inundaciones, Derrumbes o Temblores)
    public const int DesastreNatural = 247;
    //Documento Tipo Asistencia Perfecta
    public const int AsistenciaPerfecta = 197;
    //Documento Tipo Continuidad Enfermedad (12 días)
    public const int ContinuidadEnfermedad = 409;
    //Documento Tipo Falta de Agua
    public const int FaltaAgua = 190;
    //Documento Tipo Licitaciones de Instituciones del Gobierno
    public const int LicitacionInstitucionGobierno = 300;
    //Documento Tipo Teletrabajo
    public const int Teletrabajo = 194;
    //Documento Tipo No marcó Entrada (NME)
    public const int NoMarcoEntrada = 167;
    //Documento Tipo No Marcó Salida (NMS)
    public const int NoMarcoSalida = 168;
    //Reposición de Permisos con Pago Efectivo
    public const int PermisoPagoEfectivo = 220;
    //Reposición de Permisos Con Descuento Directo
    public const int PermisoDescuentoDirecto = 221;
    //Documento Resolución de Vacaciones Estándar
    public const int ResolucionVacacionesEstandar = 159;
    //Documento Tipo Resolución de Vacaciones Estándar
    public const int FaltaFluidoElectrico = 169;
    //Documento Tipo Compensatorio Tomado
    public const int CompensatorioTomado = 231;
    //Documento Tipo Permiso
    public const int Permiso = 232;
    //Documento Tipo Tiempo Extraordinario
    public const int TiempoExtraordinario = 234;
    //Documento Tipo Certificación de Horario
    public const int CertificacionHorario = 400;
    //Documento Tipo Vacaciones
    public const int Vacaciones = 235;
    //Documento Tipo Reposición de Permisos con Vacaciones
    public const int ReposicionPermisosVacaciones = 385;
    //Documento Tipo Vacaciones Institucionales
    public const int VacacionInstitucional = 458;
    //Tipo Solicitud Nota Personal
    public const int NotaPersonal = 1;
    //Tipo Solicitud Formularios OD
    public const int FormularioOd = 2;
    //Tipo Solicitud Notas Internas
    public const int NotaInterna = 3;
    //Tipo Solicitud Formularios DTP
    public const int FormularioDtp = 4;
    //Tipo Solicitud Notas Internas
    public const int NotaExterna = 5;
    //Tipo Solicitud Formularios OD Postgrado
    public const int FormularioOdPostgrado = 6;
    //Estatus Entregado Autoridad
    public const int EstatusSetEntregadoAutoridad = 221;
    //Estatus Indicaciones/Escaneo
    public const int EstatusSetIndicacionesEscaneo = 222;
    //Estatus Asignado Unidad
    public const int EstatusSetAsignadoUnidad = 223;
    //Estatus No procede
    public const int EstatusSetNoProcede = 224;
    // Estatus Anulado
    public const int EstatusSetAnulado = 11;
    // Estatus Activado
    public const int EstatusSetActivo = 4;
    // Tipo Entrada Valija
    public const int TipoEntradaValija = 1;
    // Tipo Entrada Correo
    public const int TipoEntradaCorreo = 2;
    // Tipo Entrada Presencial
    public const int TipoEntradaPresencial = 3;
    // Tipo Prioridad Alta
    public const int TipoPrioridadAlta = 1;
    // Tipo Prioridad Media
    public const int TipoPrioridadMedia = 2;
    // Tipo Prioridad Baja
    public const int TipoPrioridadBaja = 3;
    //Unidades todas
    public const int TodaUnidad = 0;
    //Pantalla asignación código reloj
    public const int PantallaAsignacionCodigoReloj = 1350;
    //Script de Aprobación de Programa Salud
    public const int ScriptAprobacionProgramaSalud = 1372;
    //Pantalla aprobación de boleta
    public const int PantallaAprobacionBoleta = 1339;
    //Unidad de Dirección General de Recursos Humanos
    public const int UnidadRrhhh = 157;
    //Cargo director
    public const int CargoDirector = 658;
    //Cargo sub-director
    public const int CargoSubdirector = 626;
    //Cargo secretaria ejecutiva
    public const int CargoSecretariaEjecutiva = 571;
}
