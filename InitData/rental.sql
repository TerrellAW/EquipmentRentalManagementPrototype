-- For rental
CREATE TABLE `rental` (
  `rental_id` int NOT NULL AUTO_INCREMENT,
  `create_date` date NOT NULL,
  `customer_id` int NOT NULL,
  PRIMARY KEY (`rental_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- For rental items
CREATE TABLE `rental_item` (
  `rental_id` int NOT NULL,
  `rental_item_last_name` int NOT NULL,
  `equipment_id` int NOT NULL,
  `create_date` date NOT NULL,
  `return_date` date NOT NULL,
  PRIMARY KEY (`rental_id`,`rental_item_last_name`),
  KEY `eqpt_id` (`equipment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;