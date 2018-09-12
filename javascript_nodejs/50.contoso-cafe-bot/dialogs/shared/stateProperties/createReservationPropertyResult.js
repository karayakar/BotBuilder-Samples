
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

module.exports = {
    ReservationResult: class {
        /**
         * 
         * @param {reservationProperty} reservationProperty 
         * @param {Enum} status 
         * @param {Object []} outcome {message:'', property:''} 
         */
        constructor(property, status, outcome) {
            this.newReservation = property ? property : '';
            this.status = status ? status : 0;
            this.outcome = outcome ? (Array.isArray(outcome) ? outcome : [outcome]): [];    
        }
    },
    reservationStatus: {
        'SUCCESS': 0,
        'INCOMPLETE': 1
    },
    ReservationOutcome: class {
        /**
         * 
         * @param {String} message 
         * @param {String} entity name 
         */
        constructor(message, entityName) {
            this.message = message ? message : '';
            this.entityName = entityName ? entityName : '';
        }
    }
};