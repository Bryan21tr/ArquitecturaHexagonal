-- Table: public.pedidos

-- DROP TABLE IF EXISTS public.pedidos;

CREATE TABLE IF NOT EXISTS public.pedidos
(
    id integer NOT NULL DEFAULT nextval('pedidos_id_seq'::regclass),
    cliente character varying(100) COLLATE pg_catalog."default" NOT NULL,
    fecha timestamp without time zone NOT NULL DEFAULT CURRENT_TIMESTAMP,
    total numeric(18,2) NOT NULL,
    CONSTRAINT pedidos_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.pedidos
    OWNER to postgres;