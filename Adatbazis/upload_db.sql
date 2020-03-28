INSERT INTO `kerdesek` (`id`, `kerdes`) VALUES
(3, '\"Hogyan szól a dal helyesen? „Vidám lelkem senki sem érti'),
(5, 'Hogy hívják az ellenséges királyt?'),
(2, 'Hogy hívják Süsü barátját?'),
(4, 'Mi Süsü kedvenc gyümölcse?'),
(1, 'Miért tagadta ki az apja Süsüt?');

INSERT INTO `tippkerdes` (`id`, `kerdes`, `valasz`) VALUES
(1, 'Hány királyt/ királynét említ a Süsü, a sárkány címü mese?', 6),
(2, 'Melyik évben készült a Süsü csapdába esik című epizód?', 1984),
(3, 'Hány szóból áll a Süsü a sárkány főcímdala?', 173);

INSERT INTO `valaszok` (`id`, `valasz`, `valaszHelyesE`, `kerdes_id`) VALUES
(1, 'mert meggyógyítja az ellenségeit', 1, 1),
(2, 'mert nem tud tüzet okáldani', 0, 1),
(3, 'mert egy feje van', 0, 1),
(4, 'mert barátságos volt', 0, 1),
(5, 'Jó királyfi', 1, 2),
(6, 'Szép királyfi', 0, 2),
(7, 'Lehetsz király(fi)', 0, 2),
(8, 'Szerencsés királyfi', 0, 2),
(9, ' se gyerek', 1, 3),
(10, ' se nő', 0, 3),
(11, ' és se férfi! Senki', 0, 3),
(12, ' senki itt a világon…\"', 0, 3),
(13, 'vadkörte ', 1, 4),
(14, 'vadszőlő', 0, 4),
(15, 'vadrózsa', 0, 4),
(16, 'vadszőlő', 0, 4),
(17, 'Torzonborz ', 1, 5),
(18, 'Csupagonosz', 0, 5),
(19, 'Arthur király', 0, 5),
(20, 'Ugrándoz', 0, 5);