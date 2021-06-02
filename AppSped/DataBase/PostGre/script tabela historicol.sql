CREATE TABLE public.historico  ( 
  CodPaciente   char(10),
  DataConsulta  Date,
  Atributo      Text,
  Observacao    Text,
  CodMedico     char(10),
  Historico     Text
)
WITHOUT OIDS 
TABLESPACE      pg_default
GO
