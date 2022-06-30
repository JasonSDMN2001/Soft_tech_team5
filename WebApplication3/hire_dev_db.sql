PGDMP                         z           hire_dev_db    13.3    13.3     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    33406    hire_dev_db    DATABASE     p   CREATE DATABASE hire_dev_db WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United Kingdom.1252';
    DROP DATABASE hire_dev_db;
                postgres    false            �           0    0    DATABASE hire_dev_db    ACL     �   REVOKE CONNECT,TEMPORARY ON DATABASE hire_dev_db FROM PUBLIC;
REVOKE ALL ON DATABASE hire_dev_db FROM postgres;
GRANT CREATE,CONNECT ON DATABASE hire_dev_db TO me;
                   postgres    false    3010                        2615    33408    hire_dev    SCHEMA        CREATE SCHEMA hire_dev;
    DROP SCHEMA hire_dev;
                getdevadmin    false            �            1259    33409    client    TABLE     i  CREATE TABLE hire_dev.client (
    email character varying(50) NOT NULL,
    username character varying(20) NOT NULL,
    pass character varying(20) NOT NULL,
    firstname character varying(30),
    lastname character varying(30),
    gender character varying(30),
    birthday date,
    pic bytea,
    description text,
    pagelink character varying(150)
);
    DROP TABLE hire_dev.client;
       hire_dev         heap    postgres    false    4            �            1259    33419    dev    TABLE     K  CREATE TABLE hire_dev.dev (
    email character varying(50) NOT NULL,
    username character varying(20) NOT NULL,
    pass character varying(20) NOT NULL,
    firstname character varying(30),
    lastname character varying(30),
    gender character varying(30),
    pic bytea,
    skills text,
    bio text,
    portfolio text
);
    DROP TABLE hire_dev.dev;
       hire_dev         heap    postgres    false    4            �            1259    33429    project    TABLE     �  CREATE TABLE hire_dev.project (
    title character varying(50) NOT NULL,
    description text NOT NULL,
    proj_type boolean NOT NULL,
    offer_show boolean NOT NULL,
    category text NOT NULL,
    subcategory text NOT NULL,
    payment_method text NOT NULL,
    max_price integer,
    interv interval,
    uptime integer,
    rec_tech text,
    dev_username character varying(20) NOT NULL,
    client_username character varying(20) NOT NULL
);
    DROP TABLE hire_dev.project;
       hire_dev         heap    postgres    false    4            �          0    33409    client 
   TABLE DATA           |   COPY hire_dev.client (email, username, pass, firstname, lastname, gender, birthday, pic, description, pagelink) FROM stdin;
    hire_dev          postgres    false    201   �       �          0    33419    dev 
   TABLE DATA           p   COPY hire_dev.dev (email, username, pass, firstname, lastname, gender, pic, skills, bio, portfolio) FROM stdin;
    hire_dev          postgres    false    202   �       �          0    33429    project 
   TABLE DATA           �   COPY hire_dev.project (title, description, proj_type, offer_show, category, subcategory, payment_method, max_price, interv, uptime, rec_tech, dev_username, client_username) FROM stdin;
    hire_dev          postgres    false    203   �       -           2606    33416    client client_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY hire_dev.client
    ADD CONSTRAINT client_pkey PRIMARY KEY (email);
 >   ALTER TABLE ONLY hire_dev.client DROP CONSTRAINT client_pkey;
       hire_dev            postgres    false    201            /           2606    33418    client client_username_key 
   CONSTRAINT     [   ALTER TABLE ONLY hire_dev.client
    ADD CONSTRAINT client_username_key UNIQUE (username);
 F   ALTER TABLE ONLY hire_dev.client DROP CONSTRAINT client_username_key;
       hire_dev            postgres    false    201            1           2606    33426    dev dev_pkey 
   CONSTRAINT     O   ALTER TABLE ONLY hire_dev.dev
    ADD CONSTRAINT dev_pkey PRIMARY KEY (email);
 8   ALTER TABLE ONLY hire_dev.dev DROP CONSTRAINT dev_pkey;
       hire_dev            postgres    false    202            3           2606    33428    dev dev_username_key 
   CONSTRAINT     U   ALTER TABLE ONLY hire_dev.dev
    ADD CONSTRAINT dev_username_key UNIQUE (username);
 @   ALTER TABLE ONLY hire_dev.dev DROP CONSTRAINT dev_username_key;
       hire_dev            postgres    false    202            5           2606    33436    project project_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY hire_dev.project
    ADD CONSTRAINT project_pkey PRIMARY KEY (title);
 @   ALTER TABLE ONLY hire_dev.project DROP CONSTRAINT project_pkey;
       hire_dev            postgres    false    203            7           2606    33442    project fk_proj_client    FK CONSTRAINT     �   ALTER TABLE ONLY hire_dev.project
    ADD CONSTRAINT fk_proj_client FOREIGN KEY (client_username) REFERENCES hire_dev.client(username);
 B   ALTER TABLE ONLY hire_dev.project DROP CONSTRAINT fk_proj_client;
       hire_dev          postgres    false    203    201    2863            6           2606    33437    project fk_proj_dev    FK CONSTRAINT        ALTER TABLE ONLY hire_dev.project
    ADD CONSTRAINT fk_proj_dev FOREIGN KEY (dev_username) REFERENCES hire_dev.dev(username);
 ?   ALTER TABLE ONLY hire_dev.project DROP CONSTRAINT fk_proj_dev;
       hire_dev          postgres    false    2867    202    203            �   *   x����uH�M���K������54�4426���D\1z\\\ ��      �      x������ � �      �      x������ � �     