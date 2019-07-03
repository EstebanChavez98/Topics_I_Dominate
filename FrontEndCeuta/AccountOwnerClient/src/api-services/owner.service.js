import Axios from 'axios';

//const RESOURCE_NAME = '/owner';
const RESOURCE_NAME = '/api/values';

export default {
    createSer(nom, dep, per, ip) {
        return Axios.get(`${RESOURCE_NAME}/${nom}&${dep}&${per}&${ip}&`)
    },
    getAll(){
        return Axios.get(RESOURCE_NAME);
    },
    get(id){
        return Axios.get(`${RESOURCE_ANME}/${id}`);
    },
    create(data){
        return Axios.post(RESOURCE_NAME, data);
    },
    update(id, data){
        return Axios.put(`${RESOURCE_NAME}/${id}, data`);
    },
    delete(id){
        return Axios.delete(`${RESOURCE_NAME}/${id}`);
    }
};