<template>
    <p class="homeText">
        WELCOME TO ACCOUNT-OWNER APPLICATION
    </p>
    <input type="text" v-model="name">
    <input type="text" v-model="dep">
    <input type="text" v-model="per">
    <input type="text" v-model="ip">
    <button @click="agregarVisita">Agregar</button>
</template>

<script>
import OwnerService from '@/api-services/owner.service';
export default {
    name: 'Home',
    data: {
        name: '',
        dep: '',
        per: '',
        ip: ''
    },
    methods:{
        agregarVisita() {
            OwnerService.createSer('this.name', 'this.dep', 'this.per', 'this.ip').then((response) => {
                console.log(response.data);
            }).catch((error) => {
                console.log(error.response.data);
            });
        }
    }
};
</script>

<style scoped>
.homeText{
    font-size: 35px;
    color: red;
    text-align: center;
    position: relative;
    top: 30px;
    text-shadow: 2px 2px 2px gray;
}
</style>